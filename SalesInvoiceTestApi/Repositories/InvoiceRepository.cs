using Microsoft.EntityFrameworkCore;
using SalesInvoiceTestApi.Data;
using SalesInvoiceTestApi.Model;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ApplicationDbContext _context;

        public InvoiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InvoiceDetail>> GetAllAsync() => await _context.InvoiceDetails.ToListAsync();

        public async Task<InvoiceDetail> GetByIdAsync(int id) => await _context.InvoiceDetails.FindAsync(id);

        public async Task AddAsync(InvoiceDetail InvoiceDetail)
        {
            _context.InvoiceDetails.Add(InvoiceDetail);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(InvoiceDetail InvoiceDetail)
        {
            _context.InvoiceDetails.Update(InvoiceDetail);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var InvoiceDetail = await _context.InvoiceDetails.FindAsync(id);
            if (InvoiceDetail != null)
            {
                _context.InvoiceDetails.Remove(InvoiceDetail);
                await _context.SaveChangesAsync();
            }
        }
    }
}
