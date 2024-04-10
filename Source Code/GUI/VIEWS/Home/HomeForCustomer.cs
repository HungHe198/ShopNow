using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.GUI.Doanhthu;
using ShopNow.Source_Code.GUI.VIEWS.Customer;
using ShopNow.Source_Code.GUI.VIEWS.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.VIEWS.Home
{
    public partial class HomeForCustomer : Form
    {
        public HomeForCustomer()
        {
            InitializeComponent();
        }

        Services Services = new Services();



        private void HomeForCustomer_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            ptb_Logo.BackColor = Color.Transparent;
            btn_ViewDetails.Enabled = false;
            Services.LoadProduct(this.dgvMainShow, null);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new ChoiceLogin());
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new Cart());
        }


        private void dgvMainShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            // Lấy dữ liệu từ row được chọn
            var selectedRow = dgvMainShow.Rows[e.RowIndex];

            // Gán giá trị cho các biến từ cells của row được chọn
            ServicesGlobalVariables.productName = selectedRow.Cells["Name"].Value.ToString();
            ServicesGlobalVariables.color = selectedRow.Cells["Color"].Value.ToString();
            ServicesGlobalVariables.price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
            ServicesGlobalVariables.quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
            ServicesGlobalVariables.display = Convert.ToSingle(selectedRow.Cells["Display"].Value);
            ServicesGlobalVariables.ram = Convert.ToInt32(selectedRow.Cells["Ram"].Value);
            ServicesGlobalVariables.rom = Convert.ToInt32(selectedRow.Cells["Rom"].Value);
            ServicesGlobalVariables.warranty = Convert.ToSingle(selectedRow.Cells["Warranty"].Value);
            ServicesGlobalVariables.description = selectedRow.Cells["Description"].Value.ToString();
            ServicesGlobalVariables.UrlImage = selectedRow.Cells["UrlImage"].Value.ToString();
            ServicesGlobalVariables.productDetailId = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());
            ServicesGlobalVariables.productId = Guid.Parse(selectedRow.Cells["ProductId"].Value.ToString());

            txt_Name.Text = ServicesGlobalVariables.productName;
            txt_Color.Text = ServicesGlobalVariables.color;
            txt_Display.Text = ServicesGlobalVariables.display.ToString();
            txt_Quantity.Text = ServicesGlobalVariables.quantity.ToString();
            txt_Price.Text = ServicesGlobalVariables.price.ToString();

        }

        private void btn_information_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.ShowDialog();
        }

        private void ptb_Logo_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            btn_ViewDetails.Enabled = true;
        }

        private void txt_Seach_TextChanged(object sender, EventArgs e)
        {
            Services.LoadProduct(this.dgvMainShow, txt_Seach.Text);
        }

        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Join("-", ServicesGlobalVariables.display, ServicesGlobalVariables.color));
            ProductDetail FormProductDetail = new ProductDetail();
            FormProductDetail.ShowDialog();
        }
    }
}
