using BlazorTreeView.Shared.Models.Devices;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace BlazorTreeView.Services
{
    /// <summary>
    /// Производит запросы к серверному приложения на чтение или запись дерева устройств
    /// </summary>
    public class DeviceHierarchyRequestServicecs
    {
        public async void SendHyerarchyAsync(List<DeviceBase> devices)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All, ReferenceLoopHandling = ReferenceLoopHandling.Ignore };
            string json = JsonConvert.SerializeObject(devices, settings);
            string body = JsonConvert.ToString(json);

            using (var httpClient = new HttpClient() { BaseAddress = new Uri("https://localhost:8000/") })
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, "Hierarchy"))
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));

                    request.Content = new StringContent(body);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }

        public async Task<List<DeviceBase>> GetDevicesAsync()
        {
            var client = new HttpClient() { BaseAddress = new Uri("https://localhost:8000/") }; // TODO Change to Depency Injection

            var response = await client.GetStringAsync("Hierarchy");
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            if (!string.IsNullOrEmpty(response))
                return JsonConvert.DeserializeObject<List<DeviceBase>>(response, settings);
            else
                return new List<DeviceBase>() { new ProjectHierarchy() { Name = "Название проекта" } };
        }

    }
}
