using SalesInvoiceTestApi.Data;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<ItemCategory>> GetAllCatItemsAsync();
        Task<IEnumerable<Item>> GetAllAsync();
        Task<Item> GetByIdAsync(int id);
        Task AddAsync(Item item);
        Task UpdateAsync(Item item);
        Task DeleteAsync(int id);
    }
}
