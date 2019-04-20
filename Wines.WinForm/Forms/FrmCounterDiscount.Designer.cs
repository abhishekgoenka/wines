namespace Wines.WinForm.Forms
{
    partial class FrmCounterDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCounterDiscount));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CboShop = new System.Windows.Forms.ComboBox();
            this.NBDiscountAmt = new System.Windows.Forms.NumericUpDown();
            this.TxtReserve = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GBControls = new System.Windows.Forms.GroupBox();
            this.dtDiscountDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblMonth = new System.Windows.Forms.Label();
            this.NBMonthDiscount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NBTotalDiscount = new System.Windows.Forms.NumericUpDown();
            this.cmdClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NBDiscountAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.GBControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBMonthDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalDiscount)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Discount Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Reserve1";
            // 
            // CboShop
            // 
            this.CboShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboShop.FormattingEnabled = true;
            this.CboShop.Location = new System.Drawing.Point(185, 23);
            this.CboShop.Name = "CboShop";
            this.CboShop.Size = new System.Drawing.Size(321, 26);
            this.CboShop.TabIndex = 0;
            // 
            // NBDiscountAmt
            // 
            this.NBDiscountAmt.Location = new System.Drawing.Point(185, 132);
            this.NBDiscountAmt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBDiscountAmt.Name = "NBDiscountAmt";
            this.NBDiscountAmt.Size = new System.Drawing.Size(120, 26);
            this.NBDiscountAmt.TabIndex = 9;
            // 
            // TxtReserve
            // 
            this.TxtReserve.Location = new System.Drawing.Point(669, 129);
            this.TxtReserve.Name = "TxtReserve";
            this.TxtReserve.Size = new System.Drawing.Size(321, 26);
            this.TxtReserve.TabIndex = 11;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(33, 277);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1061, 238);
            this.grid.TabIndex = 17;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            this.grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(67, 224);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 30);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(319, 224);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 30);
            this.BtnEdit.TabIndex = 13;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(555, 224);
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
            this.BtnSave.Location = new System.Drawing.Point(774, 224);
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
            this.BtnCancel.Location = new System.Drawing.Point(974, 224);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GBControls
            // 
            this.GBControls.Controls.Add(this.dtDiscountDate);
            this.GBControls.Controls.Add(this.label3);
            this.GBControls.Controls.Add(this.TxtDescription);
            this.GBControls.Controls.Add(this.CboShop);
            this.GBControls.Controls.Add(this.label1);
            this.GBControls.Controls.Add(this.label2);
            this.GBControls.Controls.Add(this.label5);
            this.GBControls.Controls.Add(this.TxtReserve);
            this.GBControls.Controls.Add(this.label9);
            this.GBControls.Controls.Add(this.NBDiscountAmt);
            this.GBControls.Location = new System.Drawing.Point(53, 39);
            this.GBControls.Name = "GBControls";
            this.GBControls.Size = new System.Drawing.Size(1041, 172);
            this.GBControls.TabIndex = 24;
            this.GBControls.TabStop = false;
            // 
            // dtDiscountDate
            // 
            this.dtDiscountDate.Location = new System.Drawing.Point(185, 73);
            this.dtDiscountDate.Name = "dtDiscountDate";
            this.dtDiscountDate.Size = new System.Drawing.Size(321, 26);
            this.dtDiscountDate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(669, 28);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(321, 76);
            this.TxtDescription.TabIndex = 7;
            this.TxtDescription.Text = "Description";
            // 
            // LblMonth
            // 
            this.LblMonth.AutoSize = true;
            this.LblMonth.Location = new System.Drawing.Point(50, 530);
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(158, 18);
            this.LblMonth.TabIndex = 25;
            this.LblMonth.Text = "This Month Discount";
            // 
            // NBMonthDiscount
            // 
            this.NBMonthDiscount.Enabled = false;
            this.NBMonthDiscount.Location = new System.Drawing.Point(238, 528);
            this.NBMonthDiscount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBMonthDiscount.Name = "NBMonthDiscount";
            this.NBMonthDiscount.Size = new System.Drawing.Size(150, 26);
            this.NBMonthDiscount.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Total Discount";
            // 
            // NBTotalDiscount
            // 
            this.NBTotalDiscount.Enabled = false;
            this.NBTotalDiscount.Location = new System.Drawing.Point(774, 520);
            this.NBTotalDiscount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBTotalDiscount.Name = "NBTotalDiscount";
            this.NBTotalDiscount.Size = new System.Drawing.Size(150, 26);
            this.NBTotalDiscount.TabIndex = 28;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(994, 557);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 30);
            this.cmdClose.TabIndex = 29;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // FrmCounterDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 614);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.NBTotalDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NBMonthDiscount);
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
            this.Name = "FrmCounterDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Counter Discount";
            this.Load += new System.EventHandler(this.FrmCounterDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NBDiscountAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.GBControls.ResumeLayout(false);
            this.GBControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBMonthDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboShop;
        private System.Windows.Forms.NumericUpDown NBDiscountAmt;
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
        private System.Windows.Forms.DateTimePicker dtDiscountDate;
        private System.Windows.Forms.Label LblMonth;
        private System.Windows.Forms.NumericUpDown NBMonthDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NBTotalDiscount;
        private System.Windows.Forms.Button cmdClose;
    }
}