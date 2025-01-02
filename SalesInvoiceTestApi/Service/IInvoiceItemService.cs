using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Service
{
    public interface IInvoiceItemService
    {
        Task<IEnumerable<InvoiceItem>> GetAllInvoiceItemsAsync();
        Task<InvoiceItem> GetInvoiceItemByIdAsync(int id);
        Task AddInvoiceItemAsync(InvoiceItem InvoiceItem);
        Task UpdateInvoiceItemAsync(InvoiceItem InvoiceItem);
        Task DeleteInvoiceItemAsync(int id);
    }
}
