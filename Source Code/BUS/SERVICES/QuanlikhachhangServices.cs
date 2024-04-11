using ShopNow.Models;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.BUS.SERVICES
{
    public class QuanlikhachhangServices
    {
        Customer_Repository Customer_Repository = new Customer_Repository();
        User_Repository User_Repository = new User_Repository();
        public string themCustomer(Customer customer)
        {
            try
            {
                if (customer == null)
                {
                    return "false";
                }
                else
                {
                    if (Customer_Repository.IsAddCustomer(customer))
                    {
                        return "Succes";
                    }
                    else
                    {
                        return "false";
                    }
                }
            }
            catch (Exception ex) { return ex.ToString(); }
        }
        public string themUser(User user)
        {
            try
            {
                if (user == null)
                {
                    return "false";
                }
                else
                {
                    if (User_Repository.IsAddUser(user))
                    {
                        return "Succes";
                    }
                    else
                    {
                        return "false";
                    }
                }
            }
            catch (Exception ex) { return ex.ToString(); }
        }
        Repo_GetAll getAll = new Repo_GetAll();
        public void LoadKH(DataGridView dgv,string? name )
        {
            var result = from c in getAll.GetAllCustomers(name) 
                         select new
                         {Id = c.Id,
                         User = c.Name,
                         Phone= c.PhoneNumber,
                         Email = c.Email,
                         Diachi= c.Address
                         };
            dgv.DataSource = result.ToList();
        }
        public string xoacustomer(Customer customer)
        {
            if (Customer_Repository.isDelCustomer(customer))
            {
                return "Succes";
            }
            else
            { return "Fail"; }
        }
    }
}

