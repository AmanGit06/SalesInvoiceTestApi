using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Repositories
{
    public interface IInvoiceItemRepository
    {
        Task<IEnumerable<InvoiceItem>> GetAllAsync();
        Task<InvoiceItem> GetByIdAsync(int id);
        Task AddAsync(InvoiceItem invoiceitem);
        Task UpdateAsync(InvoiceItem invoiceitem);
        Task DeleteAsync(int id);
    }
}
