using System;
using System.Linq;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.Models;

namespace Wines.WinForm.Forms
{
    public partial class FrmCounterDiscount : Form
    {
        private Int64 m_CounterDiscount_ID= 0;
        public FrmCounterDiscount()
        {
            InitializeComponent();
        }

        private void FrmCounterDiscount_Load(object sender, EventArgs e)
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
            m_CounterDiscount_ID = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CboShop.Items[CboShop.SelectedIndex] is ShopModel selectedShop)
            {
                var CounterDis = new CounterDiscount();
                var result = 0;

                if (m_CounterDiscount_ID > 0)
                {
                    // we are in edit mode
//                    public int Update(long lngID, long lngShopID, string strBranchName, string strAddress, bool bActive,
  //                                 string strMobileNo, long lngAdvance, string strReserve1)

                    result = CounterDis.Update(m_CounterDiscount_ID, selectedShop.ID, 1, dtDiscountDate.Value, 
                                        NBDiscountAmt.Value, TxtDescription.Text, TxtReserve.Text);
                }
                else
                {
                    result = CounterDis.Add(selectedShop.ID, 1, dtDiscountDate.Value,
                                        NBDiscountAmt.Value, TxtDescription.Text, TxtReserve.Text);

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
            BCL.CounterDiscount CounterDis = new BCL.CounterDiscount();
            grid.DataSource = CounterDis.GetAllCounterDiscounts();
            if (grid.Columns["ID"] != null)
            {
                grid.Columns["ID"].Visible = false;
            }

            // Fill This Month Discount
            var today = DateTime.Now;
            var dtStartDate = new DateTime(today.Year, today.Month, 1);
            var dtEndDate = dtStartDate.AddMonths(1).AddDays(-1);
            long monthDisAmount = CounterDis.GetDateRangeDiscount( dtStartDate, dtEndDate);
            long lngFullYearDiscountAmt = CounterDis.GetDiscountAmount();

            NBMonthDiscount.Value = monthDisAmount;
            NBTotalDiscount.Value = lngFullYearDiscountAmt;

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
            CounterDiscount CounterDis = new CounterDiscount();
            CounterDiscountModel CounterDisMod = CounterDis.GetAllCounterDiscounts().FirstOrDefault(b => b.ID == id);
            if (CounterDisMod != null)
            {
                //todo: Need to fix selected shop

                m_CounterDiscount_ID = CounterDisMod.ID;
                dtDiscountDate.Value= CounterDisMod.Discount_Date;
                NBDiscountAmt.Value = CounterDisMod.Discount_Amt;
                TxtDescription.Text= CounterDisMod.Description;
                TxtReserve.Text = CounterDisMod.Reserve1;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Delete?", @"Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BCL.CounterDiscount ObjCntrDiscount = new CounterDiscount();
                ObjCntrDiscount.DeleteCounterDiscount(m_CounterDiscount_ID);
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