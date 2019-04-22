using System;
using System.Linq;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.Models;
using System.Collections.Generic;

namespace Wines.WinForm.Forms
{
    public partial class FrmBranchSaleDetail : Form
    {
        public Int64 m_BranchID = 0;
        public string m_BranchName;
        public Int64 m_BranchSaleSummaryID = 0;

        private Int64 m_Edit_SaleDetailID = 0;
        private int m_Edit_GridRow_Index = 0;

        private List<BranchSaleDetailModel> m_list_branch_sale_detail_Model = new List<BranchSaleDetailModel>();

        public FrmBranchSaleDetail()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmBranchSaleDayDetail_Load(object sender, EventArgs e)
        {
            Branch ObjBranch = new Branch();
            foreach (BranchModel branchModel in ObjBranch.GetAllBranchs())
            {
                CboBranch.Items.Add(branchModel);
            }

            CboBranch.Text = m_BranchName;

            GBControls.Enabled = false;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            cboType.Items.Add("CL");
            cboType.Items.Add("IMFL");
            cboType.SelectedIndex = 0;

            FillGrid();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            m_Edit_SaleDetailID = 0;
            m_Edit_GridRow_Index = -1;

            GBControls.Enabled = true;

            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cboBrandSize.Text == "")
            {
                MessageBox.Show("Please Select Liquire Brand Name and it's size of packing");
                return;
            }
           
            BranchSaleDetailModel BranchDetailMod = new BranchSaleDetailModel();

            BranchDetailMod.ID = m_Edit_SaleDetailID;
            BranchDetailMod.Shop_ID = Auth.Instance().ShopId;
            BranchDetailMod.User_ID = Auth.Instance().User_ID;
            BranchDetailMod.Branch_ID = m_BranchID;
            BranchDetailMod.BS_Summary_ID = m_BranchSaleSummaryID;
            BranchDetailMod.Sale_Date = dtBranchSaleDate.Value;
            BranchDetailMod.Modify_Date = DateTime.Now;

            BranchDetailMod.Category = cboType.Text;

            BranchDetailMod.Brand_ID = GetSelectedBrandID();
            BranchDetailMod.Brand_Name = cboBrand.Text;
            BranchDetailMod.Brand_Size = Convert.ToInt64( cboBrandSize.Text);

            BranchDetailMod.Quantity = Convert.ToInt64( NBQuantity.Value);
            BranchDetailMod.Rate = Convert.ToInt64(NBRate.Value);
            BranchDetailMod.Amount = Convert.ToInt64(NBAmount.Value);
            BranchDetailMod.Commission = Convert.ToInt64(NBCommission.Value);
            BranchDetailMod.Reserve1 = TxtReserve.Text;

            List<BranchSaleDetailModel> listdetailModel = LoadGridDataInModel();
            if (m_Edit_GridRow_Index < 0)
                listdetailModel.Add(BranchDetailMod);
            else
                listdetailModel[m_Edit_GridRow_Index] = BranchDetailMod;

            grid.DataSource = listdetailModel;

            CalculateSummary();

            BtnAdd.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            GBControls.Enabled = false;
//                FillGrid();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            BtnAdd.Enabled = true;
            BtnEdit.Enabled = true;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            GBControls.Enabled = false;
            FillGrid();
        }

        private void FillGrid()
        {
            BCL.BranchSaleDetail branchsaleDetail = new BCL.BranchSaleDetail();
            m_list_branch_sale_detail_Model = branchsaleDetail.GetAllBranchSaleDetail(m_BranchID, m_BranchSaleSummaryID);
            grid.DataSource = m_list_branch_sale_detail_Model;

            if (grid.Columns["ID"] != null)
                grid.Columns["ID"].Visible = false;
        }

        private void CalculateSummary()
        {
            long lngTotalAmt = 0, lngTotalComm = 0, lngTotaFinalPay = 0;
            for (int r = 0; r < grid.RowCount; r++)
            {
                lngTotalAmt += Convert.ToInt64(grid.Rows[r].Cells["Amount"].Value);
                lngTotalComm += Convert.ToInt64(grid.Rows[r].Cells["Commission"].Value);
            }
            lngTotaFinalPay = lngTotalAmt - lngTotalComm;

            NBTotalPurchase.Value = lngTotalAmt;
            NBTotalCommission.Value = lngTotalComm;
            NBTotalFinalPay.Value = lngTotaFinalPay;
            NBFinalBalance.Value = (NBTotalFinalPay.Value + NBPreviousBalance.Value) - NBDeposit.Value;
        }

        private List<BranchSaleDetailModel> LoadGridDataInModel()
        {
            List<BranchSaleDetailModel> listdetailModel = new List<BranchSaleDetailModel>();
            for (int r=0; r<grid.RowCount; r++)
            {
                BranchSaleDetailModel BranchDetailMod = new BranchSaleDetailModel ();
                BranchDetailMod.ID = Convert.ToInt64(grid.Rows[r].Cells["ID"].Value);
                BranchDetailMod.Shop_ID  = Convert.ToInt64( grid.Rows[r].Cells["Shop_ID"].Value) ;
                BranchDetailMod.User_ID = Convert.ToInt64(grid.Rows[r].Cells["User_ID"].Value );
                BranchDetailMod.Branch_ID = Convert.ToInt64(grid.Rows[r].Cells["Branch_ID"].Value);
                BranchDetailMod.Brand_Name = Convert.ToString(grid.Rows[r].Cells["Brand_Name"].Value);
                BranchDetailMod.Brand_Size = Convert.ToInt64(grid.Rows[r].Cells["Brand_Size"].Value);
                BranchDetailMod.BS_Summary_ID = Convert.ToInt64(grid.Rows[r].Cells["BS_Summary_ID"].Value);

                BranchDetailMod.Sale_Date = Convert.ToDateTime(grid.Rows[r].Cells["Sale_Date"].Value );
                BranchDetailMod.Modify_Date = Convert.ToDateTime(grid.Rows[r].Cells["Modify_Date"].Value);

                BranchDetailMod.Category = Convert.ToString(grid.Rows[r].Cells["Category"].Value);

                BranchDetailMod.Brand_ID = Convert.ToInt64(grid.Rows[r].Cells["Brand_ID"].Value);
                BranchDetailMod.Brand_Name = Convert.ToString(grid.Rows[r].Cells["Brand_Name"].Value);
                BranchDetailMod.Brand_Size = Convert.ToInt64(grid.Rows[r].Cells["Brand_Size"].Value);

                BranchDetailMod.Quantity = Convert.ToInt64(grid.Rows[r].Cells["Quantity"].Value);
                BranchDetailMod.Rate = Convert.ToInt64(grid.Rows[r].Cells["Rate"].Value );
                BranchDetailMod.Amount = Convert.ToInt64(grid.Rows[r].Cells["Amount"].Value);
                BranchDetailMod.Commission = Convert.ToInt64(grid.Rows[r].Cells["Commission"].Value);
                BranchDetailMod.Reserve1 = Convert.ToString(grid.Rows[r].Cells["Reserve1"].Value );

                listdetailModel.Add(BranchDetailMod);
            }
            return listdetailModel;
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

            long id = Convert.ToInt64(grid.SelectedRows[0].Cells["ID"].Value);

            cboType.Text = Convert.ToString( grid.SelectedRows[0].Cells["Category"].Value);

            long lngBrand_ID = Convert.ToInt64(grid.SelectedRows[0].Cells["Brand_ID"].Value);
            Brand brands = new Brand();
            List<BrandModel> lstBrandModel = brands.GetBrandDetail(lngBrand_ID);

            if (lstBrandModel.Count > 0 )
            {
                cboBrand.Text = lstBrandModel[0].Liq_Name;
                cboBrandSize.Text = Convert.ToString(lstBrandModel[0].Weight);

                long lngQuantity = Convert.ToInt64(grid.SelectedRows[0].Cells["Quantity"].Value);
                NBCartoon.Value = Convert.ToInt64(lngQuantity / lstBrandModel[0].Box);
                NBQuantity.Value = lngQuantity;
            }
            else
            {
                NBQuantity.Value = Convert.ToInt64(grid.SelectedRows[0].Cells["Quantity"].Value);
            }

            NBRate.Value = Convert.ToInt64(grid.SelectedRows[0].Cells["Rate"].Value);
            NBAmount.Value = Convert.ToInt64(grid.SelectedRows[0].Cells["Amount"].Value);

            NBCommission.Value = Convert.ToInt64(grid.SelectedRows[0].Cells["Commission"].Value);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {            
            if (grid.RowCount == 0)
                return;

            m_Edit_GridRow_Index = grid.SelectedRows[0].Index;

            if (!string.IsNullOrEmpty(grid.Rows[m_Edit_GridRow_Index].Cells["ID"].Value.ToString()))
                m_Edit_SaleDetailID = Convert.ToInt64(grid.Rows[m_Edit_GridRow_Index].Cells["ID"].Value);

            GBControls.Enabled = true;

            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GBControls_Enter(object sender, EventArgs e)
        {

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBrand.Items.Clear();

            Brand brands = new Brand();
            var lstBrandModel = brands.GetUniueqBrandName(cboType.Text);
            foreach (var brandone in lstBrandModel )
            {
                cboBrand.Items.Add(brandone);
            }

            if (cboBrand.Items.Count > 0 )
                cboBrand.SelectedIndex = 0;

        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBrandSize.Items.Clear();

            Brand brands = new Brand();
            var lstBrandModel = brands.GetUniueqBrandSize(cboType.Text, cboBrand.Text);
            foreach (var brandone in lstBrandModel)
            {
                cboBrandSize.Items.Add(brandone.Weight);
            }
        }

        private void NBCartoon_Enter(object sender, EventArgs e)
        {
            NBCartoon.Select(0, NBCartoon.ToString().Length);
        }

        private void NBQuantity_Enter(object sender, EventArgs e)
        {
            NBQuantity.Select(0, NBQuantity.ToString().Length);
        }

        private void NBRate_Enter(object sender, EventArgs e)
        {
            NBRate.Select(0, NBRate.ToString().Length);
        }

        private void NBAmount_Enter(object sender, EventArgs e)
        {
            NBAmount.Select(0, NBAmount.ToString().Length);
        }

        private void NBCommission_Enter(object sender, EventArgs e)
        {
            NBCommission.Select(0, NBCommission.ToString().Length);
        }

        private void NBFinalPay_Enter(object sender, EventArgs e)
        {
            NBFinalPay.Select(0, NBFinalPay.ToString().Length);
        }

        private void NBCartoon_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboBrand.Text))
                return;

            if (string.IsNullOrEmpty(cboBrandSize.Text))
                return;

            Brand brands = new Brand();
            System.Collections.Generic.List<BrandModel> lstBrandModel = 
                                        brands.GetBrandDetail(cboType.Text, cboBrand.Text, Convert.ToInt64( cboBrandSize.Text) );

            if (lstBrandModel.Count > 0 )
            {
                BrandModel selectedBrand = lstBrandModel[0];

                NBQuantity.Value = selectedBrand.Box * NBCartoon.Value;
                NBRate.Value = selectedBrand.Sale_Rate;
                NBCommission.Value = selectedBrand.Branch_Commision * NBQuantity.Value;

                NBAmount.Value = NBRate.Value * NBQuantity.Value;
                NBFinalPay.Value = NBAmount.Value - NBCommission.Value;
            }
            else
            {
                NBQuantity.Value = 0;
                NBRate.Value = 0;
                NBCommission.Value = 0;

                NBAmount.Value = 0;
                NBFinalPay.Value = 0;
            }
        }

        private long GetSelectedBrandID()
        {
            Brand brands = new Brand();
            System.Collections.Generic.List<BrandModel> lstBrandModel =
                                        brands.GetBrandDetail(cboType.Text, cboBrand.Text, Convert.ToInt64(cboBrandSize.Text));

            if (lstBrandModel.Count > 0)
                return lstBrandModel[0].ID;
            else
                return 0;
        }
        private void NBQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboBrand.Text))
                return;

            if (string.IsNullOrEmpty(cboBrandSize.Text))
                return;

            Brand brands = new Brand();
            System.Collections.Generic.List<BrandModel> lstBrandModel =
                                        brands.GetBrandDetail(cboType.Text, cboBrand.Text, Convert.ToInt64(cboBrandSize.Text));

            if (lstBrandModel.Count > 0)
            {
                BrandModel selectedBrand = lstBrandModel[0];
                NBRate.Value = selectedBrand.Sale_Rate;
                NBCommission.Value = selectedBrand.Branch_Commision * NBQuantity.Value;

                NBAmount.Value = NBRate.Value * NBQuantity.Value;
                NBFinalPay.Value = NBAmount.Value - NBCommission.Value;

            }
            else
            {
                NBRate.Value = 0;
                NBCommission.Value = 0;

                NBAmount.Value = 0;
                NBFinalPay.Value = 0;
            }
    }

        private void NBRate_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboBrand.Text))
                return;

            if (string.IsNullOrEmpty(cboBrandSize.Text))
                return;

            Brand brands = new Brand();
            System.Collections.Generic.List<BrandModel> lstBrandModel =
                                        brands.GetBrandDetail(cboType.Text, cboBrand.Text, Convert.ToInt64(cboBrandSize.Text));

            if (lstBrandModel.Count > 0)
            {
                BrandModel selectedBrand = lstBrandModel[0];
                NBCommission.Value = selectedBrand.Branch_Commision * NBQuantity.Value;

                NBAmount.Value = NBRate.Value * NBQuantity.Value;
                NBFinalPay.Value = NBAmount.Value - NBCommission.Value;
            }
            else
            {
                NBCommission.Value = 0;

                NBAmount.Value = 0;
                NBFinalPay.Value = 0;
            }
        }

        private void NBCommission_ValueChanged(object sender, EventArgs e)
        {
            NBAmount.Value = NBRate.Value * NBQuantity.Value;
            NBFinalPay.Value = NBAmount.Value - NBCommission.Value;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSaveAll_Click(object sender, EventArgs e)
        {
            long result = 0;
            BranchSale brSale = new BranchSale();
            if (m_BranchSaleSummaryID > 0)
            {
                // we are in edit mode
                result = brSale.Update(m_BranchSaleSummaryID , Auth.Instance().ShopId, Auth.Instance().User_ID,
                    m_BranchID, dtBranchSaleDate.Value, System.DateTime.Now, Convert.ToInt64( NBPreviousBalance.Value),
                    Convert.ToInt64(NBTotalPurchase.Value), Convert.ToInt64(NBTotalCommission.Value), 
                    Convert.ToInt64(NBTotalFinalPay.Value), Convert.ToInt64(NBDeposit.Value), 
                    Convert.ToInt64(NBFinalBalance.Value), TxtReserve.Text);
            }
            else
            {
                result = brSale.Add(Auth.Instance().ShopId, Auth.Instance().User_ID,
                    m_BranchID, dtBranchSaleDate.Value, System.DateTime.Now, Convert.ToInt64(NBPreviousBalance.Value),
                    Convert.ToInt64(NBTotalPurchase.Value), Convert.ToInt64(NBTotalCommission.Value),
                    Convert.ToInt64(NBTotalFinalPay.Value), Convert.ToInt64(NBDeposit.Value),
                    Convert.ToInt64(NBFinalBalance.Value), TxtReserve.Text);

                List<BranchSaleModel> LastRecords = brSale.GetLastSavedRecord();
                m_BranchSaleSummaryID = LastRecords[0].ID;
            }

            if (result == 0)
            {
                BranchSaleDetail brSaleDetail = new BranchSaleDetail();
                List<BranchSaleDetailModel> lstdetail = LoadGridDataInModel();

                foreach (BranchSaleDetailModel SaleEntry in lstdetail)
                {
                    if (SaleEntry.ID > 0 )
                        result = brSaleDetail.Update(SaleEntry.ID, SaleEntry.Shop_ID, SaleEntry.User_ID, 
                                                SaleEntry.Branch_ID, m_BranchSaleSummaryID, 
                                                SaleEntry.Sale_Date, System.DateTime.Now, 
                                                SaleEntry.Category, SaleEntry.Brand_ID, 
                                                SaleEntry.Brand_Name, SaleEntry.Brand_Size,
                                                SaleEntry.Quantity, SaleEntry.Rate, SaleEntry.Amount, 
                                                SaleEntry.Commission, SaleEntry.Reserve1);
                    else
                        result = brSaleDetail.Add(SaleEntry.Shop_ID, SaleEntry.User_ID,
                                                SaleEntry.Branch_ID, m_BranchSaleSummaryID,
                                                SaleEntry.Sale_Date, System.DateTime.Now,
                                                SaleEntry.Category, SaleEntry.Brand_ID,
                                                SaleEntry.Brand_Name, SaleEntry.Brand_Size,
                                                SaleEntry.Quantity, SaleEntry.Rate, SaleEntry.Amount,
                                                SaleEntry.Commission, SaleEntry.Reserve1);
                }
            }
        }
    }
}