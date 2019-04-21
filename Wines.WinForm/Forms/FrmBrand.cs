﻿using System;
using System.Linq;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.ExtensionMethods;

namespace Wines.WinForm.Forms
{
    public partial class FrmBrand : Form
    {
        private readonly Brand brand = new Brand();
        private long brandid;

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
            CboShop.DataSource = shop.GetAllShops();
            CboShop.DisplayMember = "Shop_Name";
            CboShop.ValueMember = "ID";

            GBControls.Enabled = false;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // add category
            CBOCategory.DisplayMember = "Name";
            CBOCategory.ValueMember = "Key";
            CBOCategory.DataSource = brand.GetAllCategories();

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
            int result;

            if (brandid > 0)
            {
                // we are in edit mode
                result = brand.Update(brandid, CboShop.SelectedValue.ToInt64(), CBOCategory.SelectedValue.ToString(),
                    TxtLiquor.Text, NBBox.Value, NBWeight.Value,
                    NBPurchaseRate.Value, NBSaleRate.Value, NBBranchCommission.Value, TxtReserve.Text);
            }
            else
            {
                result = brand.Add(CboShop.SelectedValue.ToInt64(), CBOCategory.SelectedValue.ToString(),
                    TxtLiquor.Text,
                    NBBox.Value, NBWeight.Value,
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
            grid.DataSource = brand.GetAllBrands();
            if (grid.Columns["ID"] != null)
            {
                grid.Columns["ID"].Visible = false;
            }

            grid.Columns["Shop_ID"].HeaderText = "Shop";
            grid.Columns["Liq_Name"].HeaderText = "Liquor";
            grid.Columns["Purchase_Rate"].HeaderText = "Purchase Rate";
            grid.Columns["Sale_Rate"].HeaderText = "Sale Rate";
            grid.Columns["Branch_Commision"].HeaderText = "commission";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Delete?", @"Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
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

        private void Grid_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt64(grid.SelectedRows[0].Cells["ID"].Value);
                var brandModel = brand.GetAllBrands().FirstOrDefault(b => b.ID == id);
                if (brandModel != null)
                {
                    CboShop.SelectedValue = brandModel.Shop_ID;
                    brandid = brandModel.ID;
                    CBOCategory.SelectedValue = brandModel.Category;
                    TxtLiquor.Text = brandModel.Liq_Name;
                    NBBox.Value = brandModel.Box;
                    NBWeight.Value = brandModel.Weight;
                    NBPurchaseRate.Value = brandModel.Purchase_Rate;
                    NBSaleRate.Value = brandModel.Sale_Rate;
                    NBBranchCommission.Value = brandModel.Branch_Commision;
                    TxtReserve.Text = brandModel.Reserve1;
                }
            }
        }
    }
}