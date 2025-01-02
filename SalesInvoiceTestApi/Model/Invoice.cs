using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SalesInvoiceTestApi.Model
{

    public class InvoiceDetail
    {
        [Key]
        public int InvoiceId { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string PaymentMode { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }

        // Related InvoiceItems (One to Many relationship)
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }

}
