namespace Wines.WinForm.Models
{
    internal class BranchSaleDetailModel
    {
        public long ID { get; set; }
        public long Shop_ID { get; set; }
        public long User_ID { get; set; }
        public long Branch_ID { get; set; }
        public long BS_Summary_ID { get; set; }
        public System.DateTime Sale_Date { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Category { get; set; }
        public long Brand_ID { get; set; }
        public string Brand_Name { get; set; }
        public long Brand_Size { get; set; }
        public long Quantity { get; set; }
        public long Rate { get; set; }
        public long Amount { get; set; }
        public long Commission { get; set; }
        public string Reserve1 { get; set; }
    }
}