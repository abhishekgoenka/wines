using System;
using System.Linq;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.Models;

namespace Wines.WinForm.Forms
{
    public partial class FrmExpenses: Form
    {
        private Int64 m_ExpensesID= 0;
        public FrmExpenses()
        {
            InitializeComponent();
        }

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            Shop Objshop = new Shop();
            foreach (var shopModel in Objshop.GetAllShops())
            {
                CboShop.Items.Add(shopModel);
            }
            CboShop.SelectedIndex = 0;

            GBControls.Enabled = false;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cmbExpType.Items.Add("PAVA FOOT");
            cmbExpType.Items.Add("PAVA LESS");
            cmbExpType.Items.Add("TEA");
            cmbExpType.Items.Add("FOOD");
            cmbExpType.Items.Add("STATIONARY");
            cmbExpType.Items.Add("KIRANA");

            FillGrid();

            //grid.Columns["Branch_Name"].Width = 250;
            //grid.Columns["Active"].Width = 100;
            //grid.Columns["Address"].Width = 200;
            //grid.Columns["MobileNo"].Width = 150;
            //grid.Columns["Advance"].Width = 120;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GBControls.Enabled = true;

            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            m_ExpensesID= 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CboShop.Items[CboShop.SelectedIndex] is ShopModel selectedShop)
            {
                var ObjExpenses= new Expenses();
                var result = 0;

                if (m_ExpensesID > 0)
                {
                    // we are in edit mode
//                    public int Update(long lngID, long lngShopID, string strBranchName, string strAddress, bool bActive,
  //                                 string strMobileNo, long lngAdvance, string strReserve1)

                    result = ObjExpenses.Update(m_ExpensesID, selectedShop.ID, 1, dtExpDate.Value, 
                                        cmbExpType.Text, NBExpAmt.Value, TxtDescription.Text, TxtReserve.Text);
                }
                else
                {
                    result = ObjExpenses.Add(selectedShop.ID, 1, dtExpDate.Value,
                                        cmbExpType.Text,NBExpAmt.Value, TxtDescription.Text, TxtReserve.Text);

                }

                if (result > 0)
                {
                    MessageBox.Show(@"Record Saved");
                }

                BtnAdd.Enabled = true;
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
                BtnSave.Enabled = false;
                BtnCancel.Enabled = false;
                GBControls.Enabled = false;
                FillGrid();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            BtnAdd.Enabled = true;
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            GBControls.Enabled = false;
            FillGrid();
        }

        private void FillGrid()
        {
            BCL.Expenses ObjExpeses= new BCL.Expenses();
            grid.DataSource = ObjExpeses.GetAllExpenses();
            if (grid.Columns["ID"] != null)
            {
                grid.Columns["ID"].Visible = false;
            }

            // Fill This Month Discount
            var today = DateTime.Now;
            var dtStartDate = new DateTime(today.Year, today.Month, 1);
            var dtEndDate = dtStartDate.AddMonths(1).AddDays(-1);

            long ThisMonthExpenses = ObjExpeses.GetDateRangeExpenses( dtStartDate, dtEndDate);
            long lngFullYearExpAmt = ObjExpeses.GetExpensesAmount();

            NBMonthExpenses.Value = ThisMonthExpenses;
            NBTotalExpenses.Value = lngFullYearExpAmt;

        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
            Grid_DoubleClick(sender, e);
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0)
                return;

            var id = Convert.ToInt64(grid.SelectedRows[0].Cells["ID"].Value);
            Expenses ObjExpenses = new Expenses();
            ExpensesModel ExpMod = ObjExpenses.GetAllExpenses().FirstOrDefault(b => b.ID == id);
            if (ExpMod!= null)
            {
                //todo: Need to fix selected shop

                m_ExpensesID = ExpMod.ID;
                dtExpDate.Value= ExpMod.Exp_Date;
                cmbExpType.Text = ExpMod.Exp_Type;
                NBExpAmt.Value = ExpMod.Exp_Amt;
                TxtDescription.Text= ExpMod.Description;
                TxtReserve.Text = ExpMod.Reserve1;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Delete?", @"Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BCL.Expenses ObjExpenses = new Expenses();
                ObjExpenses.DeleteExpenses(m_ExpensesID);
                FillGrid();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GBControls.Enabled = true;

            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}