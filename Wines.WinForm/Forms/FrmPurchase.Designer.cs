namespace Wines.WinForm.Forms
{
    partial class FrmPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchase));
            this.CBOSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CboBrand = new System.Windows.Forms.ComboBox();
            this.DTPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.TxtRate = new System.Windows.Forms.TextBox();
            this.NBQty = new System.Windows.Forms.NumericUpDown();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.TxtDiffAmount = new System.Windows.Forms.TextBox();
            this.GBControls = new System.Windows.Forms.GroupBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NBQty)).BeginInit();
            this.GBControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBOSupplier
            // 
            this.CBOSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOSupplier.FormattingEnabled = true;
            this.CBOSupplier.Location = new System.Drawing.Point(135, 32);
            this.CBOSupplier.Name = "CBOSupplier";
            this.CBOSupplier.Size = new System.Drawing.Size(202, 26);
            this.CBOSupplier.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Purchase Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity(Loose)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Diff Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CboBrand
            // 
            this.CboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBrand.FormattingEnabled = true;
            this.CboBrand.Location = new System.Drawing.Point(638, 68);
            this.CboBrand.Name = "CboBrand";
            this.CboBrand.Size = new System.Drawing.Size(330, 26);
            this.CboBrand.TabIndex = 18;
            // 
            // DTPurchaseDate
            // 
            this.DTPurchaseDate.Location = new System.Drawing.Point(638, 29);
            this.DTPurchaseDate.Name = "DTPurchaseDate";
            this.DTPurchaseDate.Size = new System.Drawing.Size(177, 26);
            this.DTPurchaseDate.TabIndex = 19;
            // 
            // TxtRate
            // 
            this.TxtRate.Location = new System.Drawing.Point(638, 107);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(114, 26);
            this.TxtRate.TabIndex = 20;
            this.TxtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRate_KeyPress);
            // 
            // NBQty
            // 
            this.NBQty.Location = new System.Drawing.Point(638, 145);
            this.NBQty.Name = "NBQty";
            this.NBQty.Size = new System.Drawing.Size(114, 26);
            this.NBQty.TabIndex = 21;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(223, 184);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(114, 26);
            this.TxtAmount.TabIndex = 22;
            this.TxtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRate_KeyPress);
            // 
            // TxtDiffAmount
            // 
            this.TxtDiffAmount.Location = new System.Drawing.Point(638, 184);
            this.TxtDiffAmount.Name = "TxtDiffAmount";
            this.TxtDiffAmount.Size = new System.Drawing.Size(114, 26);
            this.TxtDiffAmount.TabIndex = 23;
            this.TxtDiffAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRate_KeyPress);
            // 
            // GBControls
            // 
            this.GBControls.Controls.Add(this.label11);
            this.GBControls.Controls.Add(this.textBox1);
            this.GBControls.Controls.Add(this.label10);
            this.GBControls.Controls.Add(this.comboBox2);
            this.GBControls.Controls.Add(this.label9);
            this.GBControls.Controls.Add(this.comboBox1);
            this.GBControls.Controls.Add(this.label8);
            this.GBControls.Controls.Add(this.numericUpDown1);
            this.GBControls.Controls.Add(this.CboBrand);
            this.GBControls.Controls.Add(this.CBOSupplier);
            this.GBControls.Controls.Add(this.label2);
            this.GBControls.Controls.Add(this.label1);
            this.GBControls.Controls.Add(this.label3);
            this.GBControls.Controls.Add(this.label4);
            this.GBControls.Controls.Add(this.TxtDiffAmount);
            this.GBControls.Controls.Add(this.label5);
            this.GBControls.Controls.Add(this.TxtAmount);
            this.GBControls.Controls.Add(this.label6);
            this.GBControls.Controls.Add(this.NBQty);
            this.GBControls.Controls.Add(this.label7);
            this.GBControls.Controls.Add(this.TxtRate);
            this.GBControls.Controls.Add(this.DTPurchaseDate);
            this.GBControls.Location = new System.Drawing.Point(12, 12);
            this.GBControls.Name = "GBControls";
            this.GBControls.Size = new System.Drawing.Size(1004, 255);
            this.GBControls.TabIndex = 24;
            this.GBControls.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Enabled = false;
            this.BtnCancel.Location = new System.Drawing.Point(636, 273);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 29;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(555, 273);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 28;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(474, 273);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(393, 273);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 26;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(312, 273);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 25;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 302);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1004, 223);
            this.grid.TabIndex = 30;
            this.grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Quantity(Cartoon)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(223, 149);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(114, 26);
            this.numericUpDown1.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 26);
            this.comboBox1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Size";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(135, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 26);
            this.comboBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(745, 26);
            this.textBox1.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Remark";
            // 
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 537);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.GBControls);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.FrmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NBQty)).EndInit();
            this.GBControls.ResumeLayout(false);
            this.GBControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBOSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboBrand;
        private System.Windows.Forms.DateTimePicker DTPurchaseDate;
        private System.Windows.Forms.TextBox TxtRate;
        private System.Windows.Forms.NumericUpDown NBQty;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.TextBox TxtDiffAmount;
        private System.Windows.Forms.GroupBox GBControls;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
    }
}