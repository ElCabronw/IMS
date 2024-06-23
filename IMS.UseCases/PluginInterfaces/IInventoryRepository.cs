using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces;

public interface IInventoryRepository
{
    Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
    Task<Inventory> GetInventoryByIdAsync(int id);
    Task UpdateInventoryAsync(Inventory inventory);
}