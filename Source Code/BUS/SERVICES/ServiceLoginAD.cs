using Microsoft.VisualBasic.ApplicationServices;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ShopNow.Source_Code.BUS.SERVICES
{
    internal class ServiceLoginAD
    {
        User_Repository _user = new User_Repository();
        Role_Repository _role = new Role_Repository();
        List<User> list = new List<User>();
        public List<User> GetUsers()
        {
            return list = _user.getallUser();
        }
        public bool CheckValidate(dynamic Check)
        {
            if (Check == null || Check.Length ==0) 
            {
                return true;
            }
            else { return false; }
        }
        public bool CheckLogin (string Username,  string Password)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (_user.CheckLogin(Username, Password).Count > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public List<User> checktk(string Username, string Password) 
        {
            return _user.CheckLogin(Username, Password).ToList();
        }
    }
    
}
