using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SalesInvoiceTestApi.Model
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        // Use CategoryId instead of ItemCategory string
        public int CategoryId { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal DiscountPercent { get; set; }
    }

}
