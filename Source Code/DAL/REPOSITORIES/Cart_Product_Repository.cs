using ShopNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{
    class Cart_Product_Repository
    {
        PRO131_EFContext context = new PRO131_EFContext();
        public bool IsAddCart_Product(CartProduct cartProduct)
        {
            try
            {
                // Thêm user vào context
                context.CartProducts.Add(cartProduct);
                MessageBox.Show(cartProduct.ToString());
                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
                // Trả về true nếu có ít nhất một bản ghi được thêm vào
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("2");
                // Xử lý ngoại lệ tại đây
                return false;
            }

        }
        public bool IsUpdateCart_Product(CartProduct obj)
        {
            try
            {
                // Thêm user vào context
                context.CartProducts.Update(obj);
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
        public bool isDelCartProduct(CartProduct obj)
        {
            try
            {


                context.CartProducts.Remove(obj);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex) { return false; }

        }
    }
}
