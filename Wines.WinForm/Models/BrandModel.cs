namespace Wines.WinForm.Models
{
    internal class BrandModel
    {
        public long ID { get; set; }
        public long Shop_ID { get; set; }
        public string Category { get; set; }
        public string Liq_Name { get; set; }
        public long Box { get; set; }
        public long Weight { get; set; }
        public long Purchase_Rate { get; set; }
        public long Sale_Rate { get; set; }
        public long Branch_Commision { get; set; }
        public string Reserve1 { get; set; }
    }
}