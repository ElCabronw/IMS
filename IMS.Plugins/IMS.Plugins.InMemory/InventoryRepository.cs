using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory;

public class InventoryRepository : IInventoryRepository
{
    private List<Inventory> _inventories;

    public InventoryRepository()
    {
        _inventories = new List<Inventory>
        {
            new Inventory { Id = 1, Name = "Laptop", Quantity = 10, Price = 1000 },
            new Inventory { Id = 2, Name = "Mouse", Quantity = 20, Price = 20 },
            new Inventory { Id = 3, Name = "Keyboard", Quantity = 15, Price = 50 },
            new Inventory { Id = 4, Name = "Monitor", Quantity = 5, Price = 200 },
            new Inventory { Id = 5, Name = "CPU", Quantity = 3, Price = 500 }
        };
    }
    public Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Task.FromResult(_inventories.AsEnumerable());
        }
        return Task.FromResult(_inventories.Where(i => i.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).AsEnumerable());
    }
    
    public Task<Inventory> GetInventoryByIdAsync(int id)
    {
        return Task.FromResult(_inventories.FirstOrDefault(i => i.Id == id));
    }
    
    public Task UpdateInventoryAsync(Inventory inventory)
    {
        var existingInventory = _inventories.FirstOrDefault(i => i.Id == inventory.Id);
        if (existingInventory != null)
        {
            existingInventory.Name = inventory.Name;
            existingInventory.Quantity = inventory.Quantity;
            existingInventory.Price = inventory.Price;
        }
        return Task.CompletedTask;
    }
}