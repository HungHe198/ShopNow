using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using ShopNow.Source_Code.GUI.VIEWS.Customer;
using ShopNow.Source_Code.GUI.VIEWS.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.Doanhthu
{
    public partial class ProductDetail : Form
    {
        public ProductDetail()
        {
            InitializeComponent();
        }
        GetById GetById = new GetById();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            ptb_Logo.BackColor = Color.Transparent;
            var ProductDetail = GetById.GetProductDetailById(ServicesGlobalVariables.productDetailId);
            if (ServicesGlobalVariables.productName == null)
            {
                lb_Name.Text = "(No Name)";
            }
            else
            {
                lb_Name.Text = ServicesGlobalVariables.productName;

            }
            if (ServicesGlobalVariables.UrlImage != null)
            //&& Services.UrlFileExists(ServicesGlobalVariables.UrlImage)
            {
                try
                {

                    ptb_Product.Load(ServicesGlobalVariables.UrlImage);
                    ptb_Product.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex) { }
            }
            txt_Color.Text = ServicesGlobalVariables.color;
            txt_Display.Text = ServicesGlobalVariables.display.ToString();
            txt_Quantity.Text = ServicesGlobalVariables.quantity.ToString();
            txt_Ram.Text = ServicesGlobalVariables.ram.ToString();
            lb_describe.Text = ServicesGlobalVariables.description;

           
            txt_Memory.Text = ProductDetail.Memory.ToString();

            //ServicesGlobalVariables.UrlImage = null;

            //ServicesGlobalVariables.productName = "";
            //ServicesGlobalVariables.color = "";
            //ServicesGlobalVariables.price = 0;
            //ServicesGlobalVariables.quantity = 0;
            //ServicesGlobalVariables.display = 0;
            //ServicesGlobalVariables.ram = 0;
            //ServicesGlobalVariables.rom = 0;
            //ServicesGlobalVariables.memory = 0;
            //ServicesGlobalVariables.warranty = 0;
            //ServicesGlobalVariables.description = "";
            //ServicesGlobalVariables.UrlImage = "";

        }

        private void lb_Name_Click(object sender, EventArgs e)
        {

        }

        Services Services = new Services();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddWithCart_Click(object sender, EventArgs e)
        {
            AddProductWithCart addProduct = new AddProductWithCart();
            addProduct.ShowDialog();
        }
    }
}
