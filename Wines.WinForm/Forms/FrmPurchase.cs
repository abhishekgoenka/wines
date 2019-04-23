using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.ExtensionMethods;

namespace Wines.WinForm.Forms
{
    public partial class FrmPurchase : Form
    {
        private long purchaseid;
        Purchase purchase = new Purchase();
        public FrmPurchase()
        {
            InitializeComponent();
        }

        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            CBOType.DisplayMember = "Name";
            CBOType.ValueMember = "Key";
            CBOType.DataSource = brand.GetAllCategories();

            Supplier supplier = new Supplier();
            CBOSupplier.DataSource = supplier.GetAllSuppliers();
            CBOSupplier.DisplayMember = "FullName";
            CBOSupplier.ValueMember = "ID";


            GBControls.Enabled = false;
            grid.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AllowUserToAddRows = false;


            FillGrid();

        }

        private void TxtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if (((TextBox) sender).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void FillGrid()
        {
            grid.DataSource = purchase.GetAllPurchases();
            if (grid.Columns["ID"] != null)
            {
                grid.Columns["ID"].Visible = false;
            }

            grid.Columns["Supplier_ID"].Visible = false;
            grid.Columns["Brand_ID"].Visible = false;


            //grid.Columns["Liq_Name"].HeaderText = "Liquor";
            //grid.Columns["Purchase_Rate"].HeaderText = "Purchase Rate";
            //grid.Columns["Sale_Rate"].HeaderText = "Sale Rate";
            //grid.Columns["Branch_Commision"].HeaderText = "commission";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GBControls.Enabled = true;

            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
            purchaseid = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int result;

            if (purchaseid > 0)
            {
                // we are in edit mode
                result = purchase.Update(purchaseid, CBOSupplier.SelectedValue.ToInt64(), CboBrand.SelectedValue.ToInt64(), DTPurchaseDate.Value, TxtRate.Text.ToInt64(), NBQty.Value, TxtAmount.Text.ToInt64(), TxtDiffAmount.Text.ToInt64());
            }
            else
            {
                result = purchase.Add(CBOSupplier.SelectedValue.ToInt64(), CboBrand.SelectedValue.ToInt64(), DTPurchaseDate.Value, TxtRate.Text.ToInt64(), NBQty.Value, TxtAmount.Text.ToInt64(), TxtDiffAmount.Text.ToInt64());
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

        private void Grid_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt64(grid.SelectedRows[0].Cells["ID"].Value);
                var list =purchase.GetPurchasesById(id);
                if (list.Rows.Count > 0)
                {
                    purchaseid = list.Rows[0]["ID"].ToInt64();
                    CBOSupplier.SelectedValue = list.Rows[0]["Supplier_ID"];
                    CboBrand.SelectedValue = list.Rows[0]["Brand_ID"];
                    DTPurchaseDate.Value = Convert.ToDateTime(list.Rows[0]["Purchase_Date"]);
                    TxtRate.Text = list.Rows[0]["Rate"].ToString();
                    NBQty.Value = list.Rows[0]["Quantity"].ToInt64();
                    TxtAmount.Text = list.Rows[0]["Amount"].ToString();
                    TxtDiffAmount.Text = list.Rows[0]["Diff_Amt"].ToString();
                }
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Delete?", @"Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                purchase.Delete(purchaseid);
                FillGrid();
            }
        }

        private void CBOType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            CboBrand.DataSource = brand.GetAllBrandsByCategory(CBOType.SelectedValue.ToString());
            CboBrand.DisplayMember = "Liq_Name";
            CboBrand.ValueMember = "ID";
        }
    }
}
