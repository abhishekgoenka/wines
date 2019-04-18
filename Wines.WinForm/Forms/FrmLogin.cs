using System;
using System.Windows.Forms;
using NLog;
using Wines.WinForm.BCL;

namespace Wines.WinForm.Forms
{
    public partial class FrmLogin : Form
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = Auth.Instance().SetUser(TxtUserName.Text, TxtPassword.Text);
            if (result)
            {
                // valid user
                Close();
            }
            else
            {
                MessageBox.Show(@"Invalid credentials");
                _logger.Warn($"Invalid credentials {TxtUserName.Text}, pass {TxtPassword.Text}");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
#if DEBUG
            TxtUserName.Text = @"Ummed";
            TxtPassword.Text = @"ummed@123";
#endif
        }
    }
}