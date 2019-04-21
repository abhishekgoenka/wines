namespace Wines.WinForm.Models
{
    internal class ExpensesModel
    {
        public long ID { get; set; }
        public long Shop_ID { get; set; }
        public long User_ID{ get; set; }

        public System.DateTime Exp_Date { get; set; }
        public System.DateTime Modify_Date { get; set; }
        public string Exp_Type{ get; set; }
        public long Exp_Amt { get; set; }
        public string Description{ get; set; }
        public string Reserve1 { get; set; }
    }
}