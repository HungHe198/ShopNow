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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    public partial class LoginStaff : Form
    {
        public LoginStaff()
        {
            InitializeComponent();
        }
        Login_repo Login_Repo = new Login_repo();
        GetById GetById = new GetById();
        public void Login(Login_repo login_repo)
        {
            try
            {
                string UserName = txt_UserName.Text;
                string Password = txt_Password.Text;

                if (login_repo.IsLoggedInStaff(UserName, Password))
                {

                    var User = GetById.GetUserByUserName(UserName);
                    ServicesGlobalVariables.userId = User.Id;

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

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }
    }
}
