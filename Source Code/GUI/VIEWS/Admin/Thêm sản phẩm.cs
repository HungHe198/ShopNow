using ShopNow.Models;
using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    public partial class Thêm_sản_phẩm : Form
    {
        public Thêm_sản_phẩm()
        {
            InitializeComponent();
        }

        private void Thêm_sản_phẩm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            // sau khi có sản phẩm mới được thêm sẽ được thêm vào bảng import history 
        }
        Product_Repository Product_Repository = new Product_Repository();
        Product_Detail_Repository Product_Detail_Repository = new Product_Detail_Repository();

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string MaSP = txt_Masanpham.Text.Trim();
            double Gia = Convert.ToDouble(txt_Gia.Text.Trim());
            int SoLuong = Convert.ToInt32(txt_quantity.Text.Trim());
            string name = txt_Tensanpham.Text;
            string chip = txtChip.Text.Trim();
            Guid productId = Guid.NewGuid();
            Product product = new Product() { Id = productId, ProductName = name, Quantity = SoLuong, CreatedTime = DateTime.Now, CreatedBy = ServicesGlobalVariables.userId };
            ProductDetail productDetail = new ProductDetail() { Id = Guid.NewGuid(), ProductId = productId, Code = MaSP };
            if (Product_Repository.IsAddProduct(product))
            {
                MessageBox.Show("Error!!");
            }
            else
            {

                if (Product_Detail_Repository.IsAddProductDetail(productDetail))
                {
                    MessageBox.Show("Error!!");
                }
                else
                {
                    MessageBox.Show("Sucess!!");

                }
            }
            this.Close();
        }
    }
}
