using System;
using System.Windows.Forms;
using NLog;
using Wines.WinForm.BCL;
using System.Data;

namespace Wines.WinForm.Forms
{
    public partial class FrmLogin : Form
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public class ComboboxItem : Object
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public FrmLogin()
        {
            InitializeComponent();

            BCL.Shop ObjShop = new BCL.Shop();
            DataTable dtShopes = ObjShop.GetAllShopes();

            foreach (DataRow drShop in dtShopes.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = drShop.Field<string>("Shop_Name"); //.ItemArray["Shop_Name"].ToString();
                item.Value = drShop.Field<Int32>("ID");
                cmbShops.Items.Add(item);
            }
            cmbShops.SelectedIndex = 0;

            BCL.User ObjUsers = new BCL.User();
            DataTable dtUsers = ObjUsers.GetAllUsers();
            foreach (DataRow drUser in dtUsers.Rows)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = drUser.Field<string>("FullName");
                item.Value = drUser.Field<string>("Username");
                CmbUsers.Items.Add(item);
            }
            CmbUsers.SelectedIndex = 0;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = Auth.Instance().SetUser(cmbShops.SelectedIndex+1, CmbUsers.Text, TxtPassword.Text);
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
    }
}