namespace Wines.WinForm.Forms
{
    partial class FrmBrand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrand));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtLiquor = new System.Windows.Forms.TextBox();
            this.NBBox = new System.Windows.Forms.NumericUpDown();
            this.NBWeight = new System.Windows.Forms.NumericUpDown();
            this.NBPurchaseRate = new System.Windows.Forms.NumericUpDown();
            this.NBSaleRate = new System.Windows.Forms.NumericUpDown();
            this.NBBranchCommission = new System.Windows.Forms.NumericUpDown();
            this.TxtReserve = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GBControls = new System.Windows.Forms.GroupBox();
            this.CBOCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NBBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBPurchaseRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBSaleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBBranchCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.GBControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liquor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Box";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Purchase Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sale Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Branch Commission";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Reserve1";
            // 
            // TxtLiquor
            // 
            this.TxtLiquor.Location = new System.Drawing.Point(162, 49);
            this.TxtLiquor.Name = "TxtLiquor";
            this.TxtLiquor.Size = new System.Drawing.Size(321, 22);
            this.TxtLiquor.TabIndex = 2;
            // 
            // NBBox
            // 
            this.NBBox.Location = new System.Drawing.Point(162, 76);
            this.NBBox.Name = "NBBox";
            this.NBBox.Size = new System.Drawing.Size(120, 22);
            this.NBBox.TabIndex = 3;
            // 
            // NBWeight
            // 
            this.NBWeight.Location = new System.Drawing.Point(162, 103);
            this.NBWeight.Name = "NBWeight";
            this.NBWeight.Size = new System.Drawing.Size(120, 22);
            this.NBWeight.TabIndex = 4;
            // 
            // NBPurchaseRate
            // 
            this.NBPurchaseRate.Location = new System.Drawing.Point(162, 130);
            this.NBPurchaseRate.Name = "NBPurchaseRate";
            this.NBPurchaseRate.Size = new System.Drawing.Size(120, 22);
            this.NBPurchaseRate.TabIndex = 5;
            // 
            // NBSaleRate
            // 
            this.NBSaleRate.Location = new System.Drawing.Point(162, 157);
            this.NBSaleRate.Name = "NBSaleRate";
            this.NBSaleRate.Size = new System.Drawing.Size(120, 22);
            this.NBSaleRate.TabIndex = 6;
            // 
            // NBBranchCommission
            // 
            this.NBBranchCommission.Location = new System.Drawing.Point(162, 184);
            this.NBBranchCommission.Name = "NBBranchCommission";
            this.NBBranchCommission.Size = new System.Drawing.Size(120, 22);
            this.NBBranchCommission.TabIndex = 7;
            // 
            // TxtReserve
            // 
            this.TxtReserve.Location = new System.Drawing.Point(162, 211);
            this.TxtReserve.Name = "TxtReserve";
            this.TxtReserve.Size = new System.Drawing.Size(321, 22);
            this.TxtReserve.TabIndex = 8;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 326);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1110, 276);
            this.grid.TabIndex = 18;
            this.grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(49, 290);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(130, 290);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(211, 290);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(292, 290);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Enabled = false;
            this.BtnCancel.Location = new System.Drawing.Point(373, 290);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GBControls
            // 
            this.GBControls.Controls.Add(this.CBOCategory);
            this.GBControls.Controls.Add(this.label2);
            this.GBControls.Controls.Add(this.label3);
            this.GBControls.Controls.Add(this.label4);
            this.GBControls.Controls.Add(this.label5);
            this.GBControls.Controls.Add(this.label6);
            this.GBControls.Controls.Add(this.TxtReserve);
            this.GBControls.Controls.Add(this.label7);
            this.GBControls.Controls.Add(this.NBBranchCommission);
            this.GBControls.Controls.Add(this.label8);
            this.GBControls.Controls.Add(this.NBSaleRate);
            this.GBControls.Controls.Add(this.label9);
            this.GBControls.Controls.Add(this.NBPurchaseRate);
            this.GBControls.Controls.Add(this.NBWeight);
            this.GBControls.Controls.Add(this.TxtLiquor);
            this.GBControls.Controls.Add(this.NBBox);
            this.GBControls.Location = new System.Drawing.Point(12, 24);
            this.GBControls.Name = "GBControls";
            this.GBControls.Size = new System.Drawing.Size(545, 255);
            this.GBControls.TabIndex = 24;
            this.GBControls.TabStop = false;
            // 
            // CBOCategory
            // 
            this.CBOCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOCategory.FormattingEnabled = true;
            this.CBOCategory.Location = new System.Drawing.Point(162, 21);
            this.CBOCategory.Name = "CBOCategory";
            this.CBOCategory.Size = new System.Drawing.Size(321, 22);
            this.CBOCategory.TabIndex = 9;
            // 
            // FrmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 614);
            this.Controls.Add(this.GBControls);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Brand";
            this.Load += new System.EventHandler(this.FrmBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NBBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBPurchaseRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBSaleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBBranchCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.GBControls.ResumeLayout(false);
            this.GBControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtLiquor;
        private System.Windows.Forms.NumericUpDown NBBox;
        private System.Windows.Forms.NumericUpDown NBWeight;
        private System.Windows.Forms.NumericUpDown NBPurchaseRate;
        private System.Windows.Forms.NumericUpDown NBSaleRate;
        private System.Windows.Forms.NumericUpDown NBBranchCommission;
        private System.Windows.Forms.TextBox TxtReserve;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GBControls;
        private System.Windows.Forms.ComboBox CBOCategory;
    }
}