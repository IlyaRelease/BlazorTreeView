using BlazorTreeView.Shared.Interfaces;

namespace BlazorTreeView.Services
{
    /// <summary>
    /// Предоставляет инструмент для уведомления о изменениях в древовидной структуре усройств
    /// </summary>
    public class NotifyerService : INotifyHierarchyChanged
    {
        public event Action DeviceHierarchyChanged;
        public void NotifyHierarchyChanged()
        {
            DeviceHierarchyChanged?.Invoke();
        }
    }
}
