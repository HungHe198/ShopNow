using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Linq;
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
                             Name = p.ProductName,
                             Color = pd.Color,
                             Price = p.Price,
                             Quantity = p.Quantity,
                             Display = p.Display,
                             Ram = p.Ram,
                             Rom = p.Rom,
                             Warranty = p.Warranty,
                             Description = p.Description,
                         };
            dgv_Product.DataSource = result.ToList();
        }
    }

}
