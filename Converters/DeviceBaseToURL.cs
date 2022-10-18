using BlazorTreeView.Shared.Models.Devices;

namespace BlazorTreeView.Converters
{
    public static class DeviceBaseToURLConverter
    {
        public static string Convert(DeviceBase device)
        {
            Type type = device.GetType();

            if (type == typeof(ControllerDevice))
            {
                return $"/ControllerDevice";
            }
            else if (type == typeof(Create))
            {
                return "/Crate";
            }
            else if (type == typeof(Slot))
            {
                return "/Slot";
            }
            else if (type == typeof(ProjectHierarchy))
            {
                return "/";
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}


