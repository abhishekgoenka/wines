namespace Wines.WinForm.Forms
{
    partial class FrmBranchSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranchSale));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CboShop = new System.Windows.Forms.ComboBox();
            this.TxtBranchName = new System.Windows.Forms.TextBox();
            this.NBAdvance = new System.Windows.Forms.NumericUpDown();
            this.TxtReserve = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GBControls = new System.Windows.Forms.GroupBox();
            this.TxtMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.cbkActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NBAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.GBControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Branch Name";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mobile No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Advance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Reserve1";
            // 
            // CboShop
            // 
            this.CboShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboShop.FormattingEnabled = true;
            this.CboShop.Location = new System.Drawing.Point(168, 25);
            this.CboShop.Name = "CboShop";
            this.CboShop.Size = new System.Drawing.Size(321, 26);
            this.CboShop.TabIndex = 0;
            // 
            // TxtBranchName
            // 
            this.TxtBranchName.Location = new System.Drawing.Point(168, 73);
            this.TxtBranchName.Name = "TxtBranchName";
            this.TxtBranchName.Size = new System.Drawing.Size(321, 26);
            this.TxtBranchName.TabIndex = 2;
            // 
            // NBAdvance
            // 
            this.NBAdvance.Location = new System.Drawing.Point(168, 170);
            this.NBAdvance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBAdvance.Name = "NBAdvance";
            this.NBAdvance.Size = new System.Drawing.Size(120, 26);
            this.NBAdvance.TabIndex = 9;
            // 
            // TxtReserve
            // 
            this.TxtReserve.Location = new System.Drawing.Point(669, 169);
            this.TxtReserve.Name = "TxtReserve";
            this.TxtReserve.Size = new System.Drawing.Size(321, 26);
            this.TxtReserve.TabIndex = 11;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(33, 351);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1061, 238);
            this.grid.TabIndex = 17;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            this.grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(67, 295);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 30);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(319, 295);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 30);
            this.BtnEdit.TabIndex = 13;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(555, 295);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 30);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(774, 295);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 30);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Enabled = false;
            this.BtnCancel.Location = new System.Drawing.Point(974, 295);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GBControls
            // 
            this.GBControls.Controls.Add(this.TxtMobile);
            this.GBControls.Controls.Add(this.label3);
            this.GBControls.Controls.Add(this.TxtAddress);
            this.GBControls.Controls.Add(this.cbkActive);
            this.GBControls.Controls.Add(this.CboShop);
            this.GBControls.Controls.Add(this.label1);
            this.GBControls.Controls.Add(this.label2);
            this.GBControls.Controls.Add(this.label4);
            this.GBControls.Controls.Add(this.label5);
            this.GBControls.Controls.Add(this.TxtReserve);
            this.GBControls.Controls.Add(this.label9);
            this.GBControls.Controls.Add(this.TxtBranchName);
            this.GBControls.Controls.Add(this.NBAdvance);
            this.GBControls.Location = new System.Drawing.Point(53, 60);
            this.GBControls.Name = "GBControls";
            this.GBControls.Size = new System.Drawing.Size(1041, 213);
            this.GBControls.TabIndex = 24;
            this.GBControls.TabStop = false;
            // 
            // TxtMobile
            // 
            this.TxtMobile.Location = new System.Drawing.Point(168, 124);
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Size = new System.Drawing.Size(321, 26);
            this.TxtMobile.TabIndex = 5;
            this.TxtMobile.Text = "Mo.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(669, 124);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(321, 26);
            this.TxtAddress.TabIndex = 7;
            this.TxtAddress.Text = "Address";
            // 
            // cbkActive
            // 
            this.cbkActive.AutoSize = true;
            this.cbkActive.Location = new System.Drawing.Point(669, 80);
            this.cbkActive.Name = "cbkActive";
            this.cbkActive.Size = new System.Drawing.Size(75, 22);
            this.cbkActive.TabIndex = 3;
            this.cbkActive.Text = "Active";
            this.cbkActive.UseVisualStyleBackColor = true;
            // 
            // FrmBranchSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
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
            this.Name = "FrmBranchSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Branch Sale";
            this.Load += new System.EventHandler(this.FrmBranchSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NBAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.GBControls.ResumeLayout(false);
            this.GBControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboShop;
        private System.Windows.Forms.TextBox TxtBranchName;
        private System.Windows.Forms.NumericUpDown NBAdvance;
        private System.Windows.Forms.TextBox TxtReserve;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GBControls;
        private System.Windows.Forms.CheckBox cbkActive;
        private System.Windows.Forms.TextBox TxtMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAddress;
    }
}