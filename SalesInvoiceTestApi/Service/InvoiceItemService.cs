using SalesInvoiceTestApi.Repositories;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Service
{
    public class InvoiceItemService :IInvoiceItemService
    {
        private readonly IInvoiceItemRepository _invoiceitemRepository;

        public InvoiceItemService(IInvoiceItemRepository invoiceRepository)
        {
            _invoiceitemRepository = invoiceRepository;
        }

        public async Task<IEnumerable<InvoiceItem>> GetAllInvoiceItemsAsync() => await _invoiceitemRepository.GetAllAsync();

        public async Task<InvoiceItem> GetInvoiceItemByIdAsync(int id) => await _invoiceitemRepository.GetByIdAsync(id);

        public async Task AddInvoiceItemAsync(InvoiceItem InvoiceItem) => await _invoiceitemRepository.AddAsync(InvoiceItem);

        public async Task UpdateInvoiceItemAsync(InvoiceItem InvoiceItem) => await _invoiceitemRepository.UpdateAsync(InvoiceItem);

        public async Task DeleteInvoiceItemAsync(int id) => await _invoiceitemRepository.DeleteAsync(id);
    }
}
