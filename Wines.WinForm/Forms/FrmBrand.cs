using System;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.Models;

namespace Wines.WinForm.Forms
{
    public partial class FrmBrand : Form
    {
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
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CboShop.Items[CboShop.SelectedIndex] is ShopModel selectedShop)
            {
                var brand = new Brand();
                var result = brand.Add(selectedShop.ID, TxtCategory.Text, TxtLiquor.Text, NBBox.Value, NBWeight.Value,
                    NBPurchaseRate.Value, NBSaleRate.Value, NBBranchCommission.Value, TxtReserve.Text);
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
    }
}