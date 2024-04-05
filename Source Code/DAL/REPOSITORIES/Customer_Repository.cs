using ShopNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{
    class Customer_Repository
    {
        PRO131_EFContext context = new PRO131_EFContext();
        public bool IsAddCustomer(Customer customer)
        {
            try
            {
                // Thêm user vào context
                context.Add(customer);
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
        public bool IsUpdateCustomer(Customer obj)
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

        public bool isDelCustomer(Customer obj)
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
    }
}
