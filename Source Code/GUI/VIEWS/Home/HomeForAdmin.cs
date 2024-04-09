using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.GUI.VIEWS.Admin;
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

namespace ShopNow.Source_Code.GUI.Thongke
{
    public partial class HomeForAdmin : Form
    {
        public HomeForAdmin()
        {
            InitializeComponent();
        }

        Services Services = new Services();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomeForAdmin_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            ptb_Logo.BackColor = Color.Transparent;
            Services.LoadProduct(this.dgvMainShow, null);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

            Services.ShowForm(this, new ChoiceLogin());
        }

        private void btn_information_Click(object sender, EventArgs e)
        {
            //dùng showdialog thôi
            //MessageBox.Show(ServicesGlobalVariables.userId.ToString());
            Information information = new Information();
            information.ShowDialog();

        }

        private void btn_management_Click(object sender, EventArgs e)
        {
            InvoiceHistory invoiceHistory = new InvoiceHistory();
            invoiceHistory.ShowDialog();
        }

        private void ptb_Logo_Click(object sender, EventArgs e)
        {

        }

       

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txt_Seach_TextChanged(object sender, EventArgs e)
        {
            Services.LoadProduct(this.dgvMainShow, txt_Seach.Text);
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
            ServicesGlobalVariables.productId = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

            txt_Name.Text = ServicesGlobalVariables.productName;
            txt_Color.Text = ServicesGlobalVariables.color;
            txt_Quantity.Text = ServicesGlobalVariables.quantity.ToString();
            if (ServicesGlobalVariables.UrlImage != null )
            //&& Services.UrlFileExists(ServicesGlobalVariables.UrlImage)
            {
                txt_SoucreImage.Text = ServicesGlobalVariables.UrlImage;
                ptb_productImage.Load(ServicesGlobalVariables.UrlImage);
                ptb_productImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            MessageBox.Show(ServicesGlobalVariables.UrlImage);

        }
    }
}
