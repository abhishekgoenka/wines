using System;
using System.Data;
using System.Windows.Forms;
using NLog;
using Wines.WinForm.BCL;
using Wines.WinForm.ExtensionMethods;
using Wines.WinForm.Models;

namespace Wines.WinForm.Forms
{
    public partial class FrmLogin : Form
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public FrmLogin()
        {
            InitializeComponent();

            var shop = new Shop();
            cmbShops.DataSource = shop.GetAllShops();
            cmbShops.DisplayMember = "Shop_Name";
            cmbShops.ValueMember = "ID";

            var ObjUsers = new User();
            var dtUsers = ObjUsers.GetAllUsers();
            foreach (DataRow drUser in dtUsers.Rows)
            {
                var item = new ComboboxItem
                {
                    Text = drUser.Field<string>("FullName"), Value = drUser.Field<string>("Username")
                };
                CmbUsers.Items.Add(item);
            }

            CmbUsers.SelectedIndex = 0;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (cmbShops.SelectedIndex > -1)
            {
                var result = Auth.Instance().SetUser(cmbShops.SelectedValue.ToInt64(), cmbShops.SelectedItem.ToString(), CmbUsers.Text, TxtPassword.Text);
                if (result)
                {
                    // valid user
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Invalid credentials");
                    _logger.Warn($"Invalid credentials {CmbUsers.Text}, pass {TxtPassword.Text}");
                }
            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
#if DEBUG
            TxtPassword.Text = @"ummed@123";
#endif
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public class ComboboxItem : object
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}