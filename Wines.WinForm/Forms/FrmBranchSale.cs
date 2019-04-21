﻿using System;
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



            BranchModel branchModelall = new BranchModel();
            branchModelall.Branch_Name = "ALL";
            CboBranch.Items.Add(branchModelall);

            Branch ObjBranch = new Branch();
            foreach (BranchModel branchModel in ObjBranch.GetAllBranchs())
            {
                CboBranch.Items.Add(branchModel);
            }

            gridSummary.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridSummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

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

                BtnAdd.Enabled = true;
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
                BtnSave.Enabled = false;
                BtnCancel.Enabled = false;
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
            FillGrid();
        }

        private void FillGrid()
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

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            // Update the labels to reflect changes to the selection.
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

            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            BtnSave.Enabled = true;
            BtnCancel.Enabled = true;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboBranch.Enabled = false;

            BCL.Branch Objbranch = new BCL.Branch();
            m_BranchID = Objbranch.GetBranchID(CboBranch.Text);
            FillGrid();
        }
    }
}