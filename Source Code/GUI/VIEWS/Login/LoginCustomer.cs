using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using ShopNow.Source_Code.GUI.Thongke;
using ShopNow.Source_Code.GUI.VIEWS.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    public partial class LoginCustomer : Form
    {
        public LoginCustomer()
        {
            InitializeComponent();
        }
        Login_repo login_Repo = new Login_repo();
        private void LoginCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //8C4B598F-6AF6-EE11-BCA0-103D1C86EA3D
            try
            {
                string UserName = txt_UserName.Text;
                string Password = txt_PassWord.Text;
                if (login_Repo.IsLoggedInCustomer(UserName, Password))
                {
                    Services.ShowForm(this, new HomeForCustomer());
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new ChoiceLogin());
        }
    }
}
