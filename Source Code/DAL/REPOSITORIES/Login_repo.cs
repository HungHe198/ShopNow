using ShopNow.Models;
using ShopNow.Source_Code.BUS.SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{

    public class Login_repo
    {
        PRO131_EFContext context = new PRO131_EFContext();
        GetById GetById = new GetById();
        public bool IsLoggedInAdmin(string UserName, string Password)
        {
            try
            {
                Guid RoleId = ServicesGlobalVariables.Admin;

                var User = GetById.GetUserByUserName(UserName);
                if (User != null && User.RoleId == RoleId)
                {
                    if (Password == User.Password)
                    {
                        ServicesGlobalVariables.userId = User.Id;
                        return true;
                    }
                    else { return false; }
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool IsLoggedInCustomer(string UserName, string Password)
        {
            try
            {
                Guid RoleId = ServicesGlobalVariables.Customer;
                var User = GetById.GetUserByUserName(UserName);
                if (User != null && User.RoleId == RoleId)
                {
                    if (Password == User.Password)
                    {
                        ServicesGlobalVariables.userId = User.Id;
                        return true;
                    }
                    else { return false; }
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
