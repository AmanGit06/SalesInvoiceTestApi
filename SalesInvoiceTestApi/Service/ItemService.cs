using SalesInvoiceTestApi.Repositories;
using SalesInvoiceTestApi.Model;
using SalesInvoiceTestApi.Data;

namespace SalesInvoiceTestApi.Service
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IEnumerable<ItemCategory>> GetAllCatItemsAsync() => await _itemRepository.GetAllCatItemsAsync();

        public async Task<IEnumerable<Item>> GetAllItemsAsync() => await _itemRepository.GetAllAsync();

        public async Task<Item> GetItemByIdAsync(int id) => await _itemRepository.GetByIdAsync(id);

        public async Task AddItemAsync(Item item) => await _itemRepository.AddAsync(item);

        public async Task UpdateItemAsync(Item item) => await _itemRepository.UpdateAsync(item);

        public async Task DeleteItemAsync(int id) => await _itemRepository.DeleteAsync(id);

    }
}
