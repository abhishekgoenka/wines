namespace Wines.WinForm
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBranchSale = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCounterSale = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExpenses = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCounterDiscount = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRptUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBarUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarShop = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.expensesToolStripMenuItem1,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUser,
            this.MenuBrand,
            this.MenuBranch});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // MenuUser
            // 
            this.MenuUser.Name = "MenuUser";
            this.MenuUser.Size = new System.Drawing.Size(143, 26);
            this.MenuUser.Text = "Users";
            this.MenuUser.Click += new System.EventHandler(this.MenuUser_Click);
            // 
            // MenuBrand
            // 
            this.MenuBrand.Name = "MenuBrand";
            this.MenuBrand.Size = new System.Drawing.Size(143, 26);
            this.MenuBrand.Text = "Brands";
            this.MenuBrand.Click += new System.EventHandler(this.MenuBrand_Click);
            // 
            // MenuBranch
            // 
            this.MenuBranch.Name = "MenuBranch";
            this.MenuBranch.Size = new System.Drawing.Size(143, 26);
            this.MenuBranch.Text = "Branches";
            this.MenuBranch.Click += new System.EventHandler(this.MenuBranch_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem1});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // purchaseToolStripMenuItem1
            // 
            this.purchaseToolStripMenuItem1.Name = "purchaseToolStripMenuItem1";
            this.purchaseToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.purchaseToolStripMenuItem1.Text = "Purchase";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBranchSale,
            this.MenuCounterSale});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.saleToolStripMenuItem.Text = "Sale";
            // 
            // MenuBranchSale
            // 
            this.MenuBranchSale.Name = "MenuBranchSale";
            this.MenuBranchSale.Size = new System.Drawing.Size(216, 26);
            this.MenuBranchSale.Text = "Branch Sale";
            this.MenuBranchSale.Click += new System.EventHandler(this.MenuBranchSale_Click_1);
            // 
            // MenuCounterSale
            // 
            this.MenuCounterSale.Name = "MenuCounterSale";
            this.MenuCounterSale.Size = new System.Drawing.Size(216, 26);
            this.MenuCounterSale.Text = "Daily Sale";
            this.MenuCounterSale.Click += new System.EventHandler(this.MenuCounterSale_Click);
            // 
            // expensesToolStripMenuItem1
            // 
            this.expensesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExpenses,
            this.MenuCounterDiscount});
            this.expensesToolStripMenuItem1.Name = "expensesToolStripMenuItem1";
            this.expensesToolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.expensesToolStripMenuItem1.Text = "Expenses";
            // 
            // MenuExpenses
            // 
            this.MenuExpenses.Name = "MenuExpenses";
            this.MenuExpenses.Size = new System.Drawing.Size(198, 26);
            this.MenuExpenses.Text = "Shop Expenses";
            this.MenuExpenses.Click += new System.EventHandler(this.MenuExpenses_Click);
            // 
            // MenuCounterDiscount
            // 
            this.MenuCounterDiscount.Name = "MenuCounterDiscount";
            this.MenuCounterDiscount.Size = new System.Drawing.Size(198, 26);
            this.MenuCounterDiscount.Text = "Counter Discount";
            this.MenuCounterDiscount.Click += new System.EventHandler(this.MenuCounterDiscount_Click_1);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRptUsers});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // MenuRptUsers
            // 
            this.MenuRptUsers.Name = "MenuRptUsers";
            this.MenuRptUsers.Size = new System.Drawing.Size(119, 26);
            this.MenuRptUsers.Text = "Users";
            this.MenuRptUsers.Click += new System.EventHandler(this.MenuRptUsers_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarUser,
            this.StatusBarSpace,
            this.StatusBarShop});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBarUser
            // 
            this.StatusBarUser.Name = "StatusBarUser";
            this.StatusBarUser.Size = new System.Drawing.Size(107, 20);
            this.StatusBarUser.Text = "Logged in user";
            // 
            // StatusBarSpace
            // 
            this.StatusBarSpace.Name = "StatusBarSpace";
            this.StatusBarSpace.Size = new System.Drawing.Size(177, 20);
            this.StatusBarSpace.Text = "                                          ";
            // 
            // StatusBarShop
            // 
            this.StatusBarShop.Name = "StatusBarShop";
            this.StatusBarShop.Size = new System.Drawing.Size(112, 20);
            this.StatusBarShop.Text = "Logged in shop";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wine Managment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuUser;
        private System.Windows.Forms.ToolStripMenuItem MenuRptUsers;
        private System.Windows.Forms.ToolStripMenuItem MenuBrand;
        private System.Windows.Forms.ToolStripMenuItem MenuBranch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarUser;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarShop;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarSpace;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuExpenses;
        private System.Windows.Forms.ToolStripMenuItem MenuCounterDiscount;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBranchSale;
        private System.Windows.Forms.ToolStripMenuItem MenuCounterSale;
    }
}

