using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using ShopNow.Source_Code.GUI.VIEWS.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.VIEWS.Customer
{
    public partial class AddProductWithCart : Form
    {
        public AddProductWithCart()
        {
            InitializeComponent();
        }

        private void AddProductWithCart_Load(object sender, EventArgs e)
        {

        }
        Services Services = new Services();
        GetById GetById = new GetById();
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                int SLMua = Convert.ToInt32(txt_Quantity.Text);
                var QuantityProduct = GetById.GetProductById(ServicesGlobalVariables.productId).Quantity;
                if (SLMua > 0 && SLMua <= QuantityProduct )
                {

                    var result = Services.AddCartProduct(ServicesGlobalVariables.productId, ServicesGlobalVariables.cartId, Convert.ToInt32(txt_Quantity.Text));
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ");

                }
            }
            catch (Exception) { MessageBox.Show("Thêm thất bại"); }
        }

    }
}
