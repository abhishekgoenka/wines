using System;
using System.Windows.Forms;
using Wines.WinForm.BCL;
using Wines.WinForm.Forms;

namespace Wines.WinForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"user clicked");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog(this);

            menuStrip1.Enabled = Auth.Instance().IsAuthenticated;
        }
    }
}