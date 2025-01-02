namespace SalesInvoiceTestApi.Data
{
    public class ItemCategory
    {

        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Category{ get; set; } // Added CategoryName
        public decimal UnitPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal TotalAmount { get; set;}  //Make calutions that unit price is 25 and 5% discount then total amount ?
    }
}
