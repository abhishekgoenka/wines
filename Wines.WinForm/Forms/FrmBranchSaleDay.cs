using System;
using System.Linq;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.Models;

namespace Wines.WinForm.Forms
{
    public partial class FrmBranchSaleDay : Form
    {
        private Int64 m_BranchID = 0;
        public FrmBranchSaleDay()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmBranchSaleDay_Load(object sender, EventArgs e)
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

            grid.Columns["Branch_Name"].Width = 250;
            grid.Columns["Active"].Width = 100;
            grid.Columns["Address"].Width = 200;
            grid.Columns["MobileNo"].Width = 150;
            grid.Columns["Advance"].Width = 120;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GBControls.Enabled = true;

            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            m_BranchID = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CboShop.Items[CboShop.SelectedIndex] is ShopModel selectedShop)
            {
                var Branch = new Branch();
                var result = 0;

                if (m_BranchID > 0)
                {
                    // we are in edit mode
//                    public int Update(long lngID, long lngShopID, string strBranchName, string strAddress, bool bActive,
  //                                 string strMobileNo, long lngAdvance, string strReserve1)

                    result = Branch.Update(m_BranchID, selectedShop.ID, TxtBranchName.Text, TxtAddress.Text, cbkActive.Checked, 
                        TxtMobile.Text, NBAdvance.Value, TxtReserve.Text);
                }
                else
                {
                    result = Branch.Add(selectedShop.ID, TxtBranchName.Text, TxtAddress.Text, cbkActive.Checked,
                        TxtMobile.Text, NBAdvance.Value, TxtReserve.Text);

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
            BCL.Branch branch = new BCL.Branch();
            grid.DataSource = branch.GetAllBranchs();
            if (grid.Columns["ID"] != null)
            {
                grid.Columns["ID"].Visible = false;
            }
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
            Branch Branch = new Branch();
            BranchModel BranchModel = Branch.GetAllBranchs().FirstOrDefault(b => b.ID == id);
            if (BranchModel != null)
            {
                //todo: Need to fix selected shop

                m_BranchID = BranchModel.ID;
                TxtBranchName.Text = BranchModel.Branch_Name;
                cbkActive.Checked = BranchModel.Active;
                TxtMobile.Text = BranchModel.MobileNo;
                TxtAddress.Text= BranchModel.Address;
                NBAdvance.Value = BranchModel.Advance;
                TxtReserve.Text = BranchModel.Reserve1;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Delete?", @"Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                BCL.Branch ObjBranch = new Branch();
                ObjBranch.DeleteBranch(m_BranchID);
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
    }
}