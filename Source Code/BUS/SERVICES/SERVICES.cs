using ShopNow.Models;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.BUS.SERVICES
{
    class Services
    {
        //public void Test()
        //{ 

        //} 
        public static void ShowForm(Form FatherForm, Form childForm)
        {
            // Đặt form hiện tại là form chủ
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Xóa các controls hiện có và thêm form mới vào
            FatherForm.Controls.Clear();
            FatherForm.Controls.Add(childForm);
            childForm.Show();
        }
        Repo_GetAll getAll = new Repo_GetAll();
        public void LoadProduct(DataGridView dgv_Product, string Contents)
        {
            var result = from p in getAll.GetAllProducts(Contents)
                         join pd in getAll.GetAllProductDetails()
                         on p.Id equals pd.ProductId
                         select
                         new
                         {
                             Id = pd.Id,
                             ProductId = pd.ProductId,
                             Name = p.ProductName,
                             Color = pd.Color,
                             Price = p.Price,
                             Quantity = p.Quantity,
                             Display = p.Display,
                             Ram = p.Ram,
                             Rom = p.Rom,

                             Warranty = p.Warranty,
                             Description = p.Description,
                             UrlImage = pd.UrlImage,
                         };
            dgv_Product.DataSource = result.ToList();
            dgv_Product.Columns["UrlImage"].Visible = false;
            dgv_Product.Columns["Id"].Visible = false;
            dgv_Product.Columns["ProductId"].Visible = false;



        }

        public static bool UrlFileExists(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD";

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch
            {
                // Nếu có lỗi, giả sử rằng ảnh không tồn tại
                return false;
            }
        }
        Cart_Product_Repository Cart_Product_Repository = new Cart_Product_Repository();
        public string AddCartProduct(Guid ProductId1, Guid CartId1, int Quantity1)
        {
            try
            {
                CartProduct cartProduct = new CartProduct() { CartId = CartId1, ProductId = ProductId1, Quantity = Quantity1, Deleted = false };
                MessageBox.Show(cartProduct.CartId.ToString() + cartProduct.ProductId.ToString() + cartProduct.Deleted.ToString());
                if (Cart_Product_Repository.IsAddCart_Product(cartProduct))
                {
                    return "Success";
                }
                else { return "False 1"; }
            }
            catch (Exception ex) { return "False"; }
        }


    }

}
