using Microsoft.VisualBasic.ApplicationServices;
using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.DAL.REPOSITORIES;
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

        Login_repo Login_repo = new Login_repo();
        public string UserName;
        public string Password;
        public Guid UserId;
        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new ChoiceLogin());
        }
        public void Login()
        {
            try
            {
                UserName = txt_UserName.Text;
                Password = txt_Password.Text;
                if (Login_repo.IsLoggedInAdmin(UserName, Password))
                {
                    Services.ShowForm(this, new HomeForAdmin());
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }
        private void btn_loginAD_Click(object sender, EventArgs e)

        {
            //8B4B598F-6AF6-EE11-BCA0-103D1C86EA3D
            Login();
        }
        private void txt_Password_Enter(object sender, EventArgs e)
        {
            

        }

        private void linkLabel1_Enter(object sender, EventArgs e)
        {
            
        }
    }


}


