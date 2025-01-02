using  SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Service
{
    public interface IInvoiceService
    {
        Task<IEnumerable<InvoiceDetail>> GetAllInvoiceDetailsAsync();
        Task<InvoiceDetail> GetInvoiceDetailByIdAsync(int id);
        Task AddInvoiceDetailAsync(InvoiceDetail InvoiceDetail);
        Task UpdateInvoiceDetailAsync(InvoiceDetail InvoiceDetail);
        Task DeleteInvoiceDetailAsync(int id);
    }
}
