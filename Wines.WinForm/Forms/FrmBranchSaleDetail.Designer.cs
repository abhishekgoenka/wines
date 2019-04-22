namespace Wines.WinForm.Forms
{
    partial class FrmBranchSaleDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranchSaleDetail));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NBRate = new System.Windows.Forms.NumericUpDown();
            this.TxtReserve = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GBControls = new System.Windows.Forms.GroupBox();
            this.cboBrandSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NBFinalPay = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.NBCommission = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NBAmount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.NBQuantity = new System.Windows.Forms.NumericUpDown();
            this.NBCartoon = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.LblBrand = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.CboBranch = new System.Windows.Forms.ComboBox();
            this.dtBranchSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.NBDeposit = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.NBFinalBalance = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.NBPreviousBalance = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.NBTotalCommission = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NBTotalFinalPay = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.NBTotalPurchase = new System.Windows.Forms.NumericUpDown();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSaveAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NBRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.GBControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBFinalPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBCartoon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBFinalBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBPreviousBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalFinalPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Branch";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(596, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Reserve1";
            // 
            // NBRate
            // 
            this.NBRate.Location = new System.Drawing.Point(168, 146);
            this.NBRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBRate.Name = "NBRate";
            this.NBRate.Size = new System.Drawing.Size(120, 26);
            this.NBRate.TabIndex = 9;
            this.NBRate.ValueChanged += new System.EventHandler(this.NBRate_ValueChanged);
            this.NBRate.Enter += new System.EventHandler(this.NBRate_Enter);
            // 
            // TxtReserve
            // 
            this.TxtReserve.Location = new System.Drawing.Point(768, 30);
            this.TxtReserve.Name = "TxtReserve";
            this.TxtReserve.Size = new System.Drawing.Size(304, 26);
            this.TxtReserve.TabIndex = 13;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(19, 331);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1093, 160);
            this.grid.TabIndex = 19;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            this.grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(19, 289);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 30);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(285, 289);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(100, 30);
            this.BtnEdit.TabIndex = 15;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(788, 289);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 30);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Enabled = false;
            this.BtnCancel.Location = new System.Drawing.Point(1008, 289);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GBControls
            // 
            this.GBControls.Controls.Add(this.cboBrandSize);
            this.GBControls.Controls.Add(this.label4);
            this.GBControls.Controls.Add(this.NBFinalPay);
            this.GBControls.Controls.Add(this.label13);
            this.GBControls.Controls.Add(this.NBCommission);
            this.GBControls.Controls.Add(this.label3);
            this.GBControls.Controls.Add(this.NBAmount);
            this.GBControls.Controls.Add(this.label12);
            this.GBControls.Controls.Add(this.NBQuantity);
            this.GBControls.Controls.Add(this.NBCartoon);
            this.GBControls.Controls.Add(this.label11);
            this.GBControls.Controls.Add(this.label10);
            this.GBControls.Controls.Add(this.label8);
            this.GBControls.Controls.Add(this.cboType);
            this.GBControls.Controls.Add(this.LblBrand);
            this.GBControls.Controls.Add(this.cboBrand);
            this.GBControls.Controls.Add(this.label5);
            this.GBControls.Controls.Add(this.TxtReserve);
            this.GBControls.Controls.Add(this.label9);
            this.GBControls.Controls.Add(this.NBRate);
            this.GBControls.Location = new System.Drawing.Point(19, 47);
            this.GBControls.Name = "GBControls";
            this.GBControls.Size = new System.Drawing.Size(1082, 233);
            this.GBControls.TabIndex = 24;
            this.GBControls.TabStop = false;
            this.GBControls.Text = "Each bottel sale detail";
            this.GBControls.Enter += new System.EventHandler(this.GBControls_Enter);
            // 
            // cboBrandSize
            // 
            this.cboBrandSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrandSize.FormattingEnabled = true;
            this.cboBrandSize.Location = new System.Drawing.Point(768, 73);
            this.cboBrandSize.Name = "cboBrandSize";
            this.cboBrandSize.Size = new System.Drawing.Size(304, 26);
            this.cboBrandSize.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Final Pay";
            // 
            // NBFinalPay
            // 
            this.NBFinalPay.Enabled = false;
            this.NBFinalPay.Location = new System.Drawing.Point(769, 198);
            this.NBFinalPay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBFinalPay.Name = "NBFinalPay";
            this.NBFinalPay.Size = new System.Drawing.Size(120, 26);
            this.NBFinalPay.TabIndex = 12;
            this.NBFinalPay.Enter += new System.EventHandler(this.NBFinalPay_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 18);
            this.label13.TabIndex = 39;
            this.label13.Text = "Commission";
            // 
            // NBCommission
            // 
            this.NBCommission.Location = new System.Drawing.Point(168, 188);
            this.NBCommission.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBCommission.Name = "NBCommission";
            this.NBCommission.Size = new System.Drawing.Size(120, 26);
            this.NBCommission.TabIndex = 11;
            this.NBCommission.ValueChanged += new System.EventHandler(this.NBCommission_ValueChanged);
            this.NBCommission.Enter += new System.EventHandler(this.NBCommission_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Amount";
            // 
            // NBAmount
            // 
            this.NBAmount.Enabled = false;
            this.NBAmount.Location = new System.Drawing.Point(769, 156);
            this.NBAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBAmount.Name = "NBAmount";
            this.NBAmount.Size = new System.Drawing.Size(120, 26);
            this.NBAmount.TabIndex = 10;
            this.NBAmount.Enter += new System.EventHandler(this.NBAmount_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(596, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 18);
            this.label12.TabIndex = 36;
            this.label12.Text = "Quantity Loose";
            // 
            // NBQuantity
            // 
            this.NBQuantity.Location = new System.Drawing.Point(768, 111);
            this.NBQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBQuantity.Name = "NBQuantity";
            this.NBQuantity.Size = new System.Drawing.Size(120, 26);
            this.NBQuantity.TabIndex = 8;
            this.NBQuantity.ValueChanged += new System.EventHandler(this.NBQuantity_ValueChanged);
            this.NBQuantity.Enter += new System.EventHandler(this.NBQuantity_Enter);
            // 
            // NBCartoon
            // 
            this.NBCartoon.Location = new System.Drawing.Point(168, 111);
            this.NBCartoon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBCartoon.Name = "NBCartoon";
            this.NBCartoon.Size = new System.Drawing.Size(120, 26);
            this.NBCartoon.TabIndex = 7;
            this.NBCartoon.ValueChanged += new System.EventHandler(this.NBCartoon_ValueChanged);
            this.NBCartoon.Enter += new System.EventHandler(this.NBCartoon_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "Cartoon(Peti)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Packing Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(168, 25);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(321, 26);
            this.cboType.TabIndex = 4;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // LblBrand
            // 
            this.LblBrand.AutoSize = true;
            this.LblBrand.Location = new System.Drawing.Point(43, 76);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(51, 18);
            this.LblBrand.TabIndex = 27;
            this.LblBrand.Text = "Brand";
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(168, 70);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(321, 26);
            this.cboBrand.TabIndex = 5;
            this.cboBrand.SelectedIndexChanged += new System.EventHandler(this.cboBrand_SelectedIndexChanged);
            // 
            // CboBranch
            // 
            this.CboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBranch.Enabled = false;
            this.CboBranch.FormattingEnabled = true;
            this.CboBranch.Location = new System.Drawing.Point(187, 9);
            this.CboBranch.Name = "CboBranch";
            this.CboBranch.Size = new System.Drawing.Size(320, 26);
            this.CboBranch.TabIndex = 1;
            // 
            // dtBranchSaleDate
            // 
            this.dtBranchSaleDate.Location = new System.Drawing.Point(719, 15);
            this.dtBranchSaleDate.Name = "dtBranchSaleDate";
            this.dtBranchSaleDate.Size = new System.Drawing.Size(304, 26);
            this.dtBranchSaleDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.NBDeposit);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.NBFinalBalance);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.NBPreviousBalance);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.NBTotalCommission);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NBTotalFinalPay);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.NBTotalPurchase);
            this.groupBox1.Location = new System.Drawing.Point(22, 528);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 102);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(421, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Deposit";
            // 
            // NBDeposit
            // 
            this.NBDeposit.Location = new System.Drawing.Point(546, 55);
            this.NBDeposit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBDeposit.Name = "NBDeposit";
            this.NBDeposit.Size = new System.Drawing.Size(120, 26);
            this.NBDeposit.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(826, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 18);
            this.label17.TabIndex = 30;
            this.label17.Text = "Balance Due";
            // 
            // NBFinalBalance
            // 
            this.NBFinalBalance.Enabled = false;
            this.NBFinalBalance.Location = new System.Drawing.Point(931, 61);
            this.NBFinalBalance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBFinalBalance.Name = "NBFinalBalance";
            this.NBFinalBalance.Size = new System.Drawing.Size(120, 26);
            this.NBFinalBalance.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 18);
            this.label18.TabIndex = 26;
            this.label18.Text = "Prevous Balance";
            // 
            // NBPreviousBalance
            // 
            this.NBPreviousBalance.Enabled = false;
            this.NBPreviousBalance.Location = new System.Drawing.Point(165, 61);
            this.NBPreviousBalance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBPreviousBalance.Name = "NBPreviousBalance";
            this.NBPreviousBalance.Size = new System.Drawing.Size(120, 26);
            this.NBPreviousBalance.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(421, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Commission";
            // 
            // NBTotalCommission
            // 
            this.NBTotalCommission.Enabled = false;
            this.NBTotalCommission.Location = new System.Drawing.Point(546, 16);
            this.NBTotalCommission.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBTotalCommission.Name = "NBTotalCommission";
            this.NBTotalCommission.Size = new System.Drawing.Size(120, 26);
            this.NBTotalCommission.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(826, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Final Pay";
            // 
            // NBTotalFinalPay
            // 
            this.NBTotalFinalPay.Enabled = false;
            this.NBTotalFinalPay.Location = new System.Drawing.Point(931, 22);
            this.NBTotalFinalPay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBTotalFinalPay.Name = "NBTotalFinalPay";
            this.NBTotalFinalPay.Size = new System.Drawing.Size(120, 26);
            this.NBTotalFinalPay.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "Total Purchase";
            // 
            // NBTotalPurchase
            // 
            this.NBTotalPurchase.Enabled = false;
            this.NBTotalPurchase.Location = new System.Drawing.Point(165, 22);
            this.NBTotalPurchase.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NBTotalPurchase.Name = "NBTotalPurchase";
            this.NBTotalPurchase.Size = new System.Drawing.Size(120, 26);
            this.NBTotalPurchase.TabIndex = 21;
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(1001, 646);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(100, 30);
            this.cmdClose.TabIndex = 33;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSaveAll
            // 
            this.cmdSaveAll.Location = new System.Drawing.Point(788, 646);
            this.cmdSaveAll.Name = "cmdSaveAll";
            this.cmdSaveAll.Size = new System.Drawing.Size(100, 30);
            this.cmdSaveAll.TabIndex = 100;
            this.cmdSaveAll.Text = "Save All";
            this.cmdSaveAll.UseVisualStyleBackColor = true;
            this.cmdSaveAll.Click += new System.EventHandler(this.cmdSaveAll_Click);
            // 
            // FrmBranchSaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 703);
            this.Controls.Add(this.cmdSaveAll);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CboBranch);
            this.Controls.Add(this.dtBranchSaleDate);
            this.Controls.Add(this.GBControls);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBranchSaleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Branch Sale Detail";
            this.Load += new System.EventHandler(this.FrmBranchSaleDayDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NBRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.GBControls.ResumeLayout(false);
            this.GBControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBFinalPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBCartoon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBFinalBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBPreviousBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalFinalPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBTotalPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NBRate;
        private System.Windows.Forms.TextBox TxtReserve;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GBControls;
        private System.Windows.Forms.ComboBox CboBranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtBranchSaleDate;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label LblBrand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NBCartoon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown NBQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NBAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NBFinalPay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NBCommission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NBTotalFinalPay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown NBTotalPurchase;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown NBTotalCommission;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown NBDeposit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown NBFinalBalance;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown NBPreviousBalance;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdSaveAll;
        private System.Windows.Forms.ComboBox cboBrandSize;
    }
}