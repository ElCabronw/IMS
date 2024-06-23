using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories;

public class InventoriesUseCase : IInventoriesUseCase
{
    private readonly IInventoryRepository _inventoryRepository;

    public InventoriesUseCase( IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }
    
    public Task<Inventory> GetInventoryByIdAsync(int id)
    {
        return _inventoryRepository.GetInventoryByIdAsync(id);
    }

    public Task UpdateInventoryAsync(Inventory inventory)
    {
        return _inventoryRepository.UpdateInventoryAsync(inventory);
    }
}