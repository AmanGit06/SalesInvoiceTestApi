using SalesInvoiceTestApi.Model;
using Microsoft.EntityFrameworkCore;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }



    }
}
