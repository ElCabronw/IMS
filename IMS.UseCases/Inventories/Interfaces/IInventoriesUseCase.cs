using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories;

public interface IInventoriesUseCase
{
    Task<Inventory> GetInventoryByIdAsync(int id);
    Task UpdateInventoryAsync(Inventory inventory);
}