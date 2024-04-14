using ShopNow.Models;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.BUS.SERVICES
{
    public class NhanVienServices
    {
        Employee_Repository Employee_Repository = new Employee_Repository();
        public string addNhanVien(Employee employee)
        {
            try {
                if (Employee_Repository.IsAddEmployee(employee))
                {
                    return "Thanh cong";
                }
                else
                    return "That bai";
            }
            catch (Exception ex)
            {
                return ex.ToString();

            }
        }
        User_Repository User_Repository = new User_Repository();    
        public string addUser(User user)
        {
            try
            {
                if (User_Repository.IsAddUser(user))
                {
                    return "Thanh cong";
                }
                else
                    return "That bai";
            }
            catch (Exception ex)
            {
                return ex.ToString();

            }
        }
    }
}
