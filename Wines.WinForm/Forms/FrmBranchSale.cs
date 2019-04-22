using System;
using System.Linq;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.Models;

namespace Wines.WinForm.Forms
{
    public partial class FrmBranchSale : Form
    {
        private Int64 m_BranchID = 0;
        public FrmBranchSale()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmBranchSale_Load(object sender, EventArgs e)
        {
            Shop Objshop = new Shop();
            foreach (ShopModel shopModel in Objshop.GetAllShops())
            {
                CboShop.Items.Add(shopModel);
            }
            CboShop.SelectedIndex = 0;

            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;

            BranchModel branchModelall = new BranchModel();
            branchModelall.Branch_Name = "ALL";
            CboBranch.Items.Add(branchModelall);

            Branch ObjBranch = new Branch();
            foreach (BranchModel branchModel in ObjBranch.GetAllBranchs())
            {
                CboBranch.Items.Add(branchModel);
            }

            if (CboBranch.Items.Count > 1 )
                CboBranch.SelectedIndex = 1;


            gridSummary.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void FillGridSummary()
        {
            BCL.BranchSale Objbranchsale = new BCL.BranchSale();
            gridSummary.DataSource = Objbranchsale.GetAllBranchSales(m_BranchID);

            if (gridSummary.Columns["ID"] != null)
                gridSummary.Columns["ID"].Visible = false;

            if (gridSummary.Columns["Shop_ID"] != null)
                gridSummary.Columns["Shop_ID"].Visible = false;

            if (gridSummary.Columns["User_ID"] != null)
                gridSummary.Columns["User_ID"].Visible = false;

        }
        private void FillGridDetail()
        {
            if (gridSummary.SelectedRows.Count == 0)
                return;

            long lngSaleSummaryID = Convert.ToInt32(gridSummary.SelectedRows[0].Cells["ID"]);

            BCL.BranchSaleDetail ObjbranchsaleDetail = new BCL.BranchSaleDetail();
            gridDetail.DataSource = ObjbranchsaleDetail.GetAllBranchSaleDetail(m_BranchID, lngSaleSummaryID);

            if (gridDetail.Columns["ID"] != null)
                gridDetail.Columns["ID"].Visible = false;

            if (gridDetail.Columns["Shop_ID"] != null)
                gridDetail.Columns["Shop_ID"].Visible = false;

            if (gridDetail.Columns["User_ID"] != null)
                gridDetail.Columns["User_ID"].Visible = false;

            if (gridDetail.Columns["Branch_ID"] != null)
                gridDetail.Columns["Branch_ID"].Visible = false;

            if (gridDetail.Columns["BS_Summary_ID"] != null)
                gridDetail.Columns["BS_Summary_ID"].Visible = false;

        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
            Grid_DoubleClick(sender, e);
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            Grid_DoubleClick(sender, e);
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (gridSummary.SelectedRows.Count == 0)
                return;

            var id = Convert.ToInt64(gridSummary.SelectedRows[0].Cells["ID"].Value);
            Branch Branch = new Branch();
            BranchModel BranchModel = Branch.GetAllBranchs().FirstOrDefault(b => b.ID == id);
            if (BranchModel != null)
            {
                //todo: Need to fix selected shop

                m_BranchID = BranchModel.ID;
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmBranchSaleDetail frmBSaleDetail = new FrmBranchSaleDetail();
            frmBSaleDetail.m_BranchID = this.m_BranchID;
            frmBSaleDetail.m_BranchName = CboBranch.Text;

            frmBSaleDetail.ShowDialog();

            FillGridSummary();
            FillGridDetail();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (gridSummary.SelectedRows.Count == 0)
                return;

            long lngSaleSummaryID = Convert.ToInt32(gridSummary.SelectedRows[0].Cells["ID"]);
            if (lngSaleSummaryID == 0)
                return;

            FrmBranchSaleDetail frmBSaleDetail = new FrmBranchSaleDetail();            
            frmBSaleDetail.m_BranchID = this.m_BranchID;
            frmBSaleDetail.m_BranchName = CboBranch.Text;

            frmBSaleDetail.m_BranchSaleSummaryID = lngSaleSummaryID;

            frmBSaleDetail.ShowDialog();
            FillGridSummary();
            FillGridDetail();
        }

        private void CboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            BCL.Branch Objbranch = new BCL.Branch();
            m_BranchID = Objbranch.GetBranchID(CboBranch.Text);
            FillGridSummary();
            FillGridDetail();

            if (CboBranch.SelectedIndex == 0)
            {
                BtnAdd.Enabled = false;
                BtnEdit.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
                BtnEdit.Enabled = true;
            }

        }
    }
}