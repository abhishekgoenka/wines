namespace Wines.WinForm.Forms
{
    partial class FrmExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpenses));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CboShop = new System.Windows.Forms.ComboBox();
            this.NBExpAmt = new System.Windows.Forms.NumericUpDown();
            this.TxtReserve = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GBControls = new System.Windows.Forms.GroupBox();
            this.dtExpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblMonth = new System.Windows.Forms.Label();
            this.NBMonthExpenses = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NBTotalExpenses = new System.Windows.Forms.NumericUpDown();
            this.cmdClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbExpType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NBExpAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.GBControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBMonthExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expenses Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expenses Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Reserve1";
            // 
            // CboShop
            // 
            this.CboShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboShop.FormattingEnabled = true;
            this.CboShop.Location = new System.Drawing.Point(220, 10);
            this.CboShop.Name = "CboShop";
            this.CboShop.Size = new System.Drawing.Size(257, 26);
            this.CboShop.TabIndex = 0;
            // 
            // NBExpAmt
            // 
            this.NBExpAmt.Location = new System.Drawing.Point(167, 74);
            this.NBExpAmt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBExpAmt.Name = "NBExpAmt";
            this.NBExpAmt.Size = new System.Drawing.Size(257, 26);
            this.NBExpAmt.TabIndex = 9;
            // 
            // TxtReserve
            // 
            this.TxtReserve.Location = new System.Drawing.Point(167, 116);
            this.TxtReserve.Name = "TxtReserve";
            this.TxtReserve.Size = new System.Drawing.Size(257, 26);
            this.TxtReserve.TabIndex = 11;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(33, 322);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1061, 293);
            this.grid.TabIndex = 17;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            this.grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(67, 251);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 30);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(319, 251);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 30);
            this.BtnEdit.TabIndex = 13;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(555, 251);
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
            this.BtnSave.Location = new System.Drawing.Point(774, 251);
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
            this.BtnCancel.Location = new System.Drawing.Point(974, 251);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GBControls
            // 
            this.GBControls.Controls.Add(this.cmbExpType);
            this.GBControls.Controls.Add(this.label6);
            this.GBControls.Controls.Add(this.dtExpDate);
            this.GBControls.Controls.Add(this.label3);
            this.GBControls.Controls.Add(this.TxtDescription);
            this.GBControls.Controls.Add(this.label2);
            this.GBControls.Controls.Add(this.label5);
            this.GBControls.Controls.Add(this.TxtReserve);
            this.GBControls.Controls.Add(this.label9);
            this.GBControls.Controls.Add(this.NBExpAmt);
            this.GBControls.Location = new System.Drawing.Point(53, 39);
            this.GBControls.Name = "GBControls";
            this.GBControls.Size = new System.Drawing.Size(1041, 183);
            this.GBControls.TabIndex = 24;
            this.GBControls.TabStop = false;
            // 
            // dtExpDate
            // 
            this.dtExpDate.Location = new System.Drawing.Point(167, 35);
            this.dtExpDate.Name = "dtExpDate";
            this.dtExpDate.Size = new System.Drawing.Size(257, 26);
            this.dtExpDate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(653, 79);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(321, 76);
            this.TxtDescription.TabIndex = 7;
            this.TxtDescription.Text = "Description";
            // 
            // LblMonth
            // 
            this.LblMonth.AutoSize = true;
            this.LblMonth.Location = new System.Drawing.Point(50, 644);
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(164, 18);
            this.LblMonth.TabIndex = 25;
            this.LblMonth.Text = "This Month Expenses";
            // 
            // NBMonthExpenses
            // 
            this.NBMonthExpenses.Enabled = false;
            this.NBMonthExpenses.Location = new System.Drawing.Point(238, 642);
            this.NBMonthExpenses.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBMonthExpenses.Name = "NBMonthExpenses";
            this.NBMonthExpenses.Size = new System.Drawing.Size(150, 26);
            this.NBMonthExpenses.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 642);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Total Expenses";
            // 
            // NBTotalExpenses
            // 
            this.NBTotalExpenses.Enabled = false;
            this.NBTotalExpenses.Location = new System.Drawing.Point(774, 634);
            this.NBTotalExpenses.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBTotalExpenses.Name = "NBTotalExpenses";
            this.NBTotalExpenses.Size = new System.Drawing.Size(150, 26);
            this.NBTotalExpenses.TabIndex = 28;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(994, 671);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 30);
            this.cmdClose.TabIndex = 29;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Expenses Type";
            // 
            // cmbExpType
            // 
            this.cmbExpType.FormattingEnabled = true;
            this.cmbExpType.Location = new System.Drawing.Point(653, 32);
            this.cmbExpType.Name = "cmbExpType";
            this.cmbExpType.Size = new System.Drawing.Size(321, 26);
            this.cmbExpType.TabIndex = 14;
            this.cmbExpType.Text = "Expenses";
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 753);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.NBTotalExpenses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboShop);
            this.Controls.Add(this.NBMonthExpenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMonth);
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
            this.Name = "FrmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NBExpAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.GBControls.ResumeLayout(false);
            this.GBControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBMonthExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboShop;
        private System.Windows.Forms.NumericUpDown NBExpAmt;
        private System.Windows.Forms.TextBox TxtReserve;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GBControls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.DateTimePicker dtExpDate;
        private System.Windows.Forms.Label LblMonth;
        private System.Windows.Forms.NumericUpDown NBMonthExpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NBTotalExpenses;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbExpType;
    }
}