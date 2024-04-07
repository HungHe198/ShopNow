﻿using ShopNow.Source_Code.GUI.VIEWS.Customer;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.BUS.SERVICES
{
    public class ServicesSalesOperations
    {
        // tính năng mua hàng chỉ áp dụng cho tài khoản trong bảng customer khi nối qua bảng cart và User
        // Xác định Giỏ hàng của người dùng đó
        // lựa chọn sản phẩm đưa vào bảng cart và cart_product của người dùng
        // nhập thông tin của khách hàng.
        // lựa chọn phương thức thanh toán Nếu không xử lí được thì chỉ cần thanh toán khi nhận hàng.
        // xác nhận đơn hàng, dữ liệu sẽ được để đến form invoiceHistory của admin
        //Nút xác nhận đã nhận hàng sẽ được bật lên để người dùng xác nhận và thanh toán.


        // hiển thị sản phẩm trong giỏ hàng của người dùng (Customer xác định);
        Cart_Repository Cart_Repository = new Cart_Repository();
        Cart_Product_Repository Cart_Product_Repository = new Cart_Product_Repository();
        Product_Repository Product_Repository = new Product_Repository();
        Product_Detail_Repository Product_Detail_Repository = new Product_Detail_Repository();
        Repo_GetAll getAll = new Repo_GetAll();
        public void LoadCart(DataGridView mainDGV, Guid userId)
        {

            var cartData = (from c in getAll.GetAllCart()
                            join cp in getAll.GetAllCartProducts() on c.Id equals cp.CartId
                            join p in getAll.GetAllProducts(null) on cp.ProductId equals p.Id
                            //join pd in getAll.GetAllProductDetails() on p.Id equals pd.ProductId.GetValueOrDefault()
                            where c.UserId == userId
                                   && c.Deleted.GetValueOrDefault() == false
                                  && cp.Deleted.GetValueOrDefault() == false
                                  && p.Deleted.GetValueOrDefault() == false
                                  && cp.Quantity != 0 && p.Quantity != 0
                            select new
                            {
                                ProductName = p.ProductName,
                                Price = p.Price.GetValueOrDefault(),
                                Quantity = cp.Quantity.GetValueOrDefault(),
                                TotalPrice = (double)cp.Quantity.GetValueOrDefault() * (double)p.Price.GetValueOrDefault(),
                                //UrlImage = pd.UrlImage,
                            }).ToList();
            // Gán BindingList làm DataSource cho DataGridView
            mainDGV.DataSource = cartData;
            mainDGV.Columns["ProductName"].Width = 472;
            mainDGV.Columns["Price"].Width = 260;
            mainDGV.Columns["Quantity"].Width = 100;
            mainDGV.Columns["TotalPrice"].Width = 260;
            //mainDGV.Columns["UrlImage"].Visible = false;
        }
    }
}
