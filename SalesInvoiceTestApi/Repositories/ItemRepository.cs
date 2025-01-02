using Microsoft.EntityFrameworkCore;
using SalesInvoiceTestApi.Data;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item>> GetAllAsync() => await _context.Items.ToListAsync();

        public async Task<Item> GetByIdAsync(int id) => await _context.Items.FindAsync(id);

        public async Task AddAsync(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Item item)
        {
            _context.Items.Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item != null)
            {
                _context.Items.Remove(item);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ItemCategory>> GetAllCatItemsAsync()
        {
            return await(from item in _context.Items
                         join category in _context.Categories
                         on item.CategoryId equals category.CategoryId
                         select new ItemCategory
                         {
                             ItemId = item.ItemId,
                             ItemCode = item.ItemCode,
                             ItemName = item.ItemName,
                             Category = category.CategoryName,
                             UnitPrice = item.UnitPrice,
                             DiscountPercent = item.DiscountPercent,
                             TotalAmount = item.UnitPrice - (item.UnitPrice * (item.DiscountPercent / 100))
                         }).ToListAsync();
        }
    }
}
