using SalesInvoiceTestApi.Data;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Service
{
    public interface IItemService
    {
        Task<IEnumerable<ItemCategory>> GetAllCatItemsAsync();
        Task<IEnumerable<Item>> GetAllItemsAsync();
        Task<Item> GetItemByIdAsync(int id);
        Task AddItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(int id);
    }
}
