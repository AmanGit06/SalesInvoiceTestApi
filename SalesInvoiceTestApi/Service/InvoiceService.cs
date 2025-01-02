using SalesInvoiceTestApi.Model;
using SalesInvoiceTestApi.Repositories;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Service
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<IEnumerable<InvoiceDetail>> GetAllInvoiceDetailsAsync() => await _invoiceRepository.GetAllAsync();

        public async Task<InvoiceDetail> GetInvoiceDetailByIdAsync(int id) => await _invoiceRepository.GetByIdAsync(id);

        public async Task AddInvoiceDetailAsync(InvoiceDetail InvoiceDetail) => await _invoiceRepository.AddAsync(InvoiceDetail);

        public async Task UpdateInvoiceDetailAsync(InvoiceDetail InvoiceDetail) => await _invoiceRepository.UpdateAsync(InvoiceDetail);

        public async Task DeleteInvoiceDetailAsync(int id) => await _invoiceRepository.DeleteAsync(id);
    }
}
