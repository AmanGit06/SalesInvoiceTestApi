using Microsoft.EntityFrameworkCore;
using SalesInvoiceTestApi.Data;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Repositories
{
    public class InvoiceItemRepository : IInvoiceItemRepository
    {
        private readonly ApplicationDbContext _context;

        public InvoiceItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InvoiceItem>> GetAllAsync() => await _context.InvoiceItems.ToListAsync();

        public async Task<InvoiceItem> GetByIdAsync(int id) => await _context.InvoiceItems.FindAsync(id);

        public async Task AddAsync(InvoiceItem invoiceitem)
        {
            _context.InvoiceItems.Add(invoiceitem);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(InvoiceItem invoiceitem)
        {
            _context.InvoiceItems.Update(invoiceitem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var invoiceitem = await _context.InvoiceItems.FindAsync(id);
            if (invoiceitem != null)
            {
                _context.InvoiceItems.Remove(invoiceitem);
                await _context.SaveChangesAsync();
            }
        }
    }
}
