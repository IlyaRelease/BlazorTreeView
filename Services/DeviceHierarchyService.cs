using BlazorTreeView.Shared.Interfaces;
using BlazorTreeView.Shared.Models.Devices;

namespace BlazorTreeView.Services
{
    /// <summary>
    /// Хранит текущее дерево устройств, текущий выбранный элементв и уведомляет об их изменении
    /// </summary>
    public class DeviceHierarchyService
    {
        ControllerDevice controllerDevice;

        public DeviceHierarchyService()
        {
            Devices = new List<DeviceBase>();
        }

        private List<DeviceBase> devices;
        public List<DeviceBase> Devices
        {
            get => devices;
            set
            {
                devices = value;
            }
        }

        private DeviceBase selectedDevice;  
        public DeviceBase SelectedDevice
        {
            get => selectedDevice;
            set
            {
                selectedDevice = value;
            }
        }

        public async Task<List<DeviceBase>> GetDevicesAsync()
        {
            return Devices;
        }
    }
}
