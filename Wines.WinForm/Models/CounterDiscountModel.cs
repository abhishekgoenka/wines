namespace Wines.WinForm.Models
{
    internal class CounterDiscountModel
    {
        public long ID { get; set; }
        public long Shop_ID { get; set; }
        public long User_ID{ get; set; }

        public System.DateTime Discount_Date { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public long Discount_Amt { get; set; }
        public string Description{ get; set; }
        public string Reserve1 { get; set; }
    }
}