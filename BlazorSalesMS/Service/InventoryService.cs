using BlazorSalesMS.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorSalesMS.Service
{
    public class InventoryService
    {
        readonly ApplicationDbContext _dbContext;
        public InventoryService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Inventory>> InventoryList()
        {
            return await _dbContext.Inventories.ToListAsync();
        }
        public async Task<bool> InsertInventory(Inventory inventory)
        {
            await _dbContext.Inventories.AddAsync(inventory);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
