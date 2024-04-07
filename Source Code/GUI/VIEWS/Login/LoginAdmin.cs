using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.GUI.Thongke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    public partial class LoginAdmin : Form
    {
        private object errorProvider;

        public object errorProvider1 { get; private set; }

        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new ChoiceLogin());
        }

        private void btn_loginAD_Click_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            string username = txttk1.Text;
            string password = txtmk1.Text;

            using (var db = new MyEntities())
            {
                var user = db.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Services.ShowForm(this, new HomeForAdmin());
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e, ErrorProvider errorProvider)
        {
            if (string.IsNullOrEmpty(txttk1.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txttk1, "Vui lòng nhập tên người dùng!");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtmk1.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txttk1, "Vui lòng nhập mật khẩu!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
    
