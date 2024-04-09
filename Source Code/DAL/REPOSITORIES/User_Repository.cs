using Microsoft.VisualBasic.ApplicationServices;
using ShopNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = ShopNow.Models.User;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{
    class User_Repository
    {
        PRO131_EFContext context = new PRO131_EFContext();
        public List<User> getallUser()
        {
            return context.Users.ToList();
        }
        public bool IsAddUser(User user)
        {
            try
            {
                // Thêm user vào context
                context.Add(user);
                // Lưu thay đổi vào cơ sở dữ liệu
                int result = context.SaveChanges();
                // Trả về true nếu có ít nhất một bản ghi được thêm vào
                return result > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây
                return false;
            }

        }

        public bool IsUpdateUser(User obj)
        {
            try
            {
                // Thêm user vào context
                context.Update(obj);
                // Lưu thay đổi vào cơ sở dữ liệu
                int result = context.SaveChanges();
                // Trả về true nếu có ít nhất một bản ghi được thêm vào
                return result > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây
                return false;
            }

        }
        public bool isDelUser(User obj)
        {
            try
            {
                obj.Deleted = true;
                context.Update(obj);
                int result = context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<User> CheckLogin(string Usernames, string password)
        {
            return context.Users.Where(x => x.Username == Usernames && x.Password == password).ToList();
        }

    }
}
