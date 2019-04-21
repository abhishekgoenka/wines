namespace Wines.WinForm.Models
{
    internal class BranchSaleDayModel
    {
        public long ID { get; set; }
        public long Shop_ID { get; set; }
        public long Branch_ID{ get; set; }
        public System.DateTime Sale_Date { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public long Previous_Amt { get; set; }
        public long Sale_Amt_With_Comm { get; set; }
        public long Commission_Amt { get; set; }
        public long Sale_Amt_After_Comm { get; set; }
        public long Deposit { get; set; }
        public long Balance { get; set; }
        public string Reserve1 { get; set; }
    }
}