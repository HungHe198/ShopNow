using ShopNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{
    // Giỏ hàng luôn được tạo tự động khi khách hàng tạo tài khoản
    // và mỗi khách hàng chỉ có duy nhất một giỏ hàng
    class Bill_Repository
    {
        PRO131_EFContext context = new PRO131_EFContext();
        public bool IsAddBill(Bill bill)
        {
            try
            {
                // Thêm user vào context
                context.Add(bill);
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
        public bool IsUpdateBill(Bill obj)
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
        public bool isDelBill(Bill obj)
        {
            try
            {
                obj.Deleted = true;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
