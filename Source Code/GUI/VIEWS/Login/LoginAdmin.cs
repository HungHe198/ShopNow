using Microsoft.VisualBasic.ApplicationServices;
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
        ServiceLoginAD ServiceLoginADs = new ServiceLoginAD();

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
            User users = new();
            if (ServiceLoginADs.CheckLogin(txttk1.Text,txtmk1.Text))
            {
                users = ServiceLoginADs.checktk(txttk1.Text, txtmk1.Text).Find(x => x.Username == txttk1.Text && x.Password == txtmk1.Text);
                if (users.IsInRole == "ADmin")
                {
                    Services.ShowForm(this, new ChoiceLogin());
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        //private void txtUsername_Validating(object sender, CancelEventArgs e, ErrorProvider errorProvider)
        //{
        //    if (string.IsNullOrEmpty(txttk1.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(txttk1, "Vui lòng nhập tên người dùng!");
        //    }
        //    else
        //    {
        //        errorProvider.Clear();
        //    }
        //}

        //private void txtPassword_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtmk1.Text))
        //    {
        //        e.Cancel = true;
        //        errorProvider.SetError(txttk1, "Vui lòng nhập mật khẩu!");
        //    }
        //    else
        //    {
        //        errorProvider1.Clear();
        //    }
        //}
    }
}
    
