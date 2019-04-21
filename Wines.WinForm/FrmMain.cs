using System;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.Forms;
using Wines.WinForm.Reports;

namespace Wines.WinForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"user clicked");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog(this);

            menuStrip1.Enabled = Auth.Instance().IsAuthenticated;
            StatusBarUser.Text = $@"Logged in user : {Auth.Instance().Username}";
            StatusBarShop.Text = $@"Logged in shop : {Auth.Instance().ShopName}";
        }

        private void MenuRptUsers_Click(object sender, EventArgs e)
        {
            User user = new User();
            Report rpt = new Report();

            //show user report
            rpt.ShowAllUsers(user.GetAllUsers());
        }

        private void MenuBrand_Click(object sender, EventArgs e)
        {
            var brand = new FrmBrand();
            brand.ShowDialog(this);

        }

        private void MenuBranch_Click(object sender, EventArgs e)
        {
            FrmBranch branch = new FrmBranch();
            branch.ShowDialog(this);
        }

        private void MenuBranchSale_Click(object sender, EventArgs e)
        {
            FrmBranchSale branchSale = new FrmBranchSale();
            branchSale.ShowDialog(this);
        }

        private void MenuCounterDiscount_Click(object sender, EventArgs e)
        {
            FrmCounterDiscount CntrDis = new FrmCounterDiscount();
            CntrDis.ShowDialog(this);
        }

        private void MenuExpenses_Click(object sender, EventArgs e)
        {
            FrmExpenses frmExpenses = new FrmExpenses();
            frmExpenses.ShowDialog(this);
        }

        private void MenuCounterDiscount_Click_1(object sender, EventArgs e)
        {
            FrmCounterDiscount frmCounter_Discount = new FrmCounterDiscount();
            frmCounter_Discount.ShowDialog(this);
        }

        private void MenuBranchSale_Click_1(object sender, EventArgs e)
        {
            FrmBranchSale frmBrSale = new FrmBranchSale();
            frmBrSale.ShowDialog(this);
        }

        private void MenuCounterSale_Click(object sender, EventArgs e)
        {
            FrmCounterSale frmCntrSale = new FrmCounterSale();
            frmCntrSale.ShowDialog(this);
        }

        private void MenuPurchase_Click(object sender, EventArgs e)
        {
            FrmPurchase purchase = new FrmPurchase();
            purchase.ShowDialog(this);
        }
    }
}