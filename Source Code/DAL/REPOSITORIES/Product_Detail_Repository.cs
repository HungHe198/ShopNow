using ShopNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{
    class Product_Detail_Repository
    {
        PRO131_EFContext context = new PRO131_EFContext();
        public bool IsAddProductDetail(ProductDetail productDetail)
        {
            try
            {
                // Thêm user vào context
                context.Add(productDetail);
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
        public bool IsUpdateProductDetail(ProductDetail obj)
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
        public bool isDelProductDetail(ProductDetail obj)
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
