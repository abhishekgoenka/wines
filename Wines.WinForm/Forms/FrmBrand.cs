using System;
using System.Linq;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.Models;

namespace Wines.WinForm.Forms
{
    public partial class FrmBrand : Form
    {
        private Int64 brandid = 0;
        public FrmBrand()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmBrand_Load(object sender, EventArgs e)
        {
            var shop = new Shop();
            foreach (var shopModel in shop.GetAllShops())
            {
                CboShop.Items.Add(shopModel);
            }

            CboShop.SelectedIndex = 0;
            GBControls.Enabled = false;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FillGrid();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GBControls.Enabled = true;

            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            brandid = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CboShop.Items[CboShop.SelectedIndex] is ShopModel selectedShop)
            {
                var brand = new Brand();
                var result = 0;

                if (brandid > 0)
                {
                    // we are in edit mode
                    result = brand.Update(brandid, selectedShop.ID, TxtCategory.Text, TxtLiquor.Text, NBBox.Value, NBWeight.Value,
                        NBPurchaseRate.Value, NBSaleRate.Value, NBBranchCommission.Value, TxtReserve.Text);
                }
                else
                {
                    result = brand.Add(selectedShop.ID, TxtCategory.Text, TxtLiquor.Text, NBBox.Value, NBWeight.Value,
                        NBPurchaseRate.Value, NBSaleRate.Value, NBBranchCommission.Value, TxtReserve.Text);

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
            var brand = new Brand();
            grid.DataSource = brand.GetAllBrands();
            if (grid.Columns["ID"] != null)
            {
                grid.Columns["ID"].Visible = false;
            }
        }


        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            var id = Convert.ToInt64(grid.SelectedRows[0].Cells["ID"].Value);
            Brand brand = new Brand();
            BrandModel brandModel = brand.GetAllBrands().FirstOrDefault(b => b.ID == id);
            if (brandModel != null)
            {
                //todo: Need to fix selected shop

                brandid = brandModel.ID;
                TxtCategory.Text = brandModel.Category;
                TxtLiquor.Text = brandModel.Liq_Name;
                NBBox.Value = brandModel.Box;
                NBWeight.Value = brandModel.Weight;
                NBPurchaseRate.Value = brandModel.Purchase_Rate;
                NBSaleRate.Value = brandModel.Sale_Rate;
                NBBranchCommission.Value = brandModel.Branch_Commision;
                TxtReserve.Text = brandModel.Reserve1;

            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Delete?", @"Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Brand brand = new Brand();
                brand.DeleteBrand(brandid);
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
    }
}