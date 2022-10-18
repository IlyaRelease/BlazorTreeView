using BlazorTreeView;
using BlazorTreeView.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:8000/") });
builder.Services.AddSingleton<DeviceHierarchyService>();
builder.Services.AddSingleton<DeviceHierarchyRequestServicecs>();
builder.Services.AddSingleton<NotifyerService>();
builder.Services.AddBlazorContextMenu();


await builder.Build().RunAsync();

