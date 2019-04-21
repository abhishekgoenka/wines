namespace Wines.WinForm.Models
{
    internal class BranchModel
    {
        public long ID { get; set; }
        public long Shop_ID { get; set; }
        public string Branch_Name{ get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }
        public string MobileNo { get; set; }
        public long Advance { get; set; }
        public string Reserve1 { get; set; }

        public override string ToString()
        {
            return Branch_Name;
        }
    }
}