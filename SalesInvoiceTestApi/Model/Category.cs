using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SalesInvoiceTestApi.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
