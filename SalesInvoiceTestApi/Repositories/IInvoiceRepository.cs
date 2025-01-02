using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Repositories
{
    public interface IInvoiceRepository
    {
        Task<IEnumerable<InvoiceDetail>> GetAllAsync();
        Task<InvoiceDetail> GetByIdAsync(int invoiceid);
        Task AddAsync(InvoiceDetail invoicedetail);
        Task UpdateAsync(InvoiceDetail invoicedetail);
        Task DeleteAsync(int invoiceid);
    }
}
