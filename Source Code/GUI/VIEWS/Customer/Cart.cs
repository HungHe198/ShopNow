using ShopNow.Models;
using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using ShopNow.Source_Code.GUI.Doanhthu;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ShopNow.Source_Code.GUI.VIEWS.Customer
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }
        ServicesSalesOperations operations = new ServicesSalesOperations();
        Services Services = new Services();
        Guid CartId;
        Guid ProductId;


        private void Cart_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            //LoadDataGridView của giỏ hàng
            ptb_Logo.BackColor = Color.Transparent;
            dgvMainCart.SelectionMode = (DataGridViewSelectionMode)SelectionMode.One;

            operations.LoadCart(this.dgvMainCart, ServicesGlobalVariables.userId);
            //LoadCart(userId);

            btn_Save.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                if ((Convert.ToInt32(txt_Quantity.Text) == 0) || string.IsNullOrEmpty(txt_Quantity.Text))
                {
                    operations.IsDelCartProduct(CartId, ProductId);
                }
                else
                {
                    operations.IsUpdateCartProduct(CartId, ProductId, Convert.ToInt32(txt_Quantity.Text));
                }

            }
            catch (Exception ex)
            {
                operations.LoadCart(this.dgvMainCart, ServicesGlobalVariables.userId);
            }
            CartId = Guid.Empty;
            ProductId = Guid.Empty;
            txt_Name.Text = string.Empty;
            txt_Price.Text = string.Empty;
            txt_Quantity.Text = string.Empty;
            txt_totalPrice.Text = string.Empty;
            Services.ShowForm(this, new formTrong());

            btn_Save.Enabled = false;
        }



        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {

                btn_Save.Enabled = true;
            }
            catch (Exception ex)
            {
                btn_Save.Enabled = false;
            }
        }

        //private void dgvMainCart_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    if (e.RowIndex >= 0)
        //    {
        //        // Extract and display data from the selected row
        //        DataGridViewRow selectedRow = dgvMainCart.Rows[e.RowIndex];
        //        txt_Name.Text = selectedRow.Cells["ProductName"].Value?.ToString();
        //        txt_Price.Text = selectedRow.Cells["Price"].Value?.ToString();
        //        txt_Quantity.Text = selectedRow.Cells["Quantity"].Value?.ToString();
        //        txt_totalPrice.Text = selectedRow.Cells["TotalPrice"].Value?.ToString();
        //        CartId = Guid.Parse(selectedRow.Cells["CartId"].Value.ToString());
        //        ProductId = Guid.Parse(selectedRow.Cells["ProductId"].Value.ToString());
        //    }

        //}


        private void ptb_Logo_Click_1(object sender, EventArgs e)
        {

            Services.ShowForm(this, new HomeForCustomer());

        }

        private void dgvMainCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Extract and display data from the selected row
                DataGridViewRow selectedRow = dgvMainCart.Rows[e.RowIndex];
                txt_Name.Text = selectedRow.Cells["ProductName"].Value?.ToString();
                txt_Price.Text = selectedRow.Cells["Price"].Value?.ToString();
                txt_Quantity.Text = selectedRow.Cells["Quantity"].Value?.ToString();
                txt_totalPrice.Text = selectedRow.Cells["TotalPrice"].Value?.ToString();
                CartId = Guid.Parse(selectedRow.Cells["CartId"].Value.ToString());
                ProductId = Guid.Parse(selectedRow.Cells["ProductId"].Value.ToString());
                ServicesGlobalVariables.productId = ProductId;
                ServicesGlobalVariables.productDetailId = Guid.Parse(selectedRow.Cells["ProductDetailId"].Value.ToString());
                ServicesGlobalVariables.productName = txt_Name.Text;
                ServicesGlobalVariables.color = selectedRow.Cells["Color"].Value?.ToString();

                GetById getById = new GetById();
                var productDetail = getById.GetProductDetailById(Guid.Parse(selectedRow.Cells["ProductDetailId"].Value.ToString()));
                var productDescription = getById.GetProductById(ProductId).Description;
                ServicesGlobalVariables.memory = productDetail.Memory.ToString();
                ServicesGlobalVariables.ram = Convert.ToInt32(productDetail.Ram);
                ServicesGlobalVariables.display = Convert.ToInt32(productDetail.Display);
                ServicesGlobalVariables.description = productDescription;
                ServicesGlobalVariables.quantity = Convert.ToInt32(selectedRow.Cells["SoLuongConLai"].Value?.ToString());



            }
        }



        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {
            Doanhthu.ProductDetail productDetail = new Doanhthu.ProductDetail();
            productDetail.ShowDialog();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            DeliveryInformation deliveryInformation = new DeliveryInformation();
            deliveryInformation.ShowDialog();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_DelAll_Click(object sender, EventArgs e)
        {

        }

        private void btn_PH_Click(object sender, EventArgs e)
        {
            BUS.SERVICES.Services.ShowForm(this, new PurchaseHistory());
        }
    }
}
