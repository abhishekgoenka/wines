﻿namespace Wines.WinForm.Forms
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
            ((System.ComponentModel.ISupportInitialize)(this.NBQty)).BeginInit();
            this.GBControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // CBOSupplier
            // 
            this.CBOSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOSupplier.FormattingEnabled = true;
            this.CBOSupplier.Location = new System.Drawing.Point(135, 32);
            this.CBOSupplier.Name = "CBOSupplier";
            this.CBOSupplier.Size = new System.Drawing.Size(321, 22);
            this.CBOSupplier.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Purchase Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Diff Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CboBrand
            // 
            this.CboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBrand.FormattingEnabled = true;
            this.CboBrand.Location = new System.Drawing.Point(606, 32);
            this.CboBrand.Name = "CboBrand";
            this.CboBrand.Size = new System.Drawing.Size(321, 22);
            this.CboBrand.TabIndex = 18;
            // 
            // DTPurchaseDate
            // 
            this.DTPurchaseDate.Location = new System.Drawing.Point(135, 76);
            this.DTPurchaseDate.Name = "DTPurchaseDate";
            this.DTPurchaseDate.Size = new System.Drawing.Size(321, 22);
            this.DTPurchaseDate.TabIndex = 19;
            // 
            // TxtRate
            // 
            this.TxtRate.Location = new System.Drawing.Point(135, 120);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(114, 22);
            this.TxtRate.TabIndex = 20;
            this.TxtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRate_KeyPress);
            // 
            // NBQty
            // 
            this.NBQty.Location = new System.Drawing.Point(606, 120);
            this.NBQty.Name = "NBQty";
            this.NBQty.Size = new System.Drawing.Size(114, 22);
            this.NBQty.TabIndex = 21;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(135, 164);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(114, 22);
            this.TxtAmount.TabIndex = 22;
            this.TxtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRate_KeyPress);
            // 
            // TxtDiffAmount
            // 
            this.TxtDiffAmount.Location = new System.Drawing.Point(606, 164);
            this.TxtDiffAmount.Name = "TxtDiffAmount";
            this.TxtDiffAmount.Size = new System.Drawing.Size(114, 22);
            this.TxtDiffAmount.TabIndex = 23;
            this.TxtDiffAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRate_KeyPress);
            // 
            // GBControls
            // 
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
            this.GBControls.Size = new System.Drawing.Size(1004, 243);
            this.GBControls.TabIndex = 24;
            this.GBControls.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Enabled = false;
            this.BtnCancel.Location = new System.Drawing.Point(639, 261);
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
            this.BtnSave.Location = new System.Drawing.Point(558, 261);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 28;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(477, 261);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(396, 261);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 26;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(315, 261);
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
            // FrmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
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
    }
}