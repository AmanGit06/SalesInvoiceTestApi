using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SalesInvoiceTestApi.Model
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemId { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        //public Item Item { get; set; }
    }
}

