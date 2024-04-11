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
    public partial class Quản_lí_khách_hàng : Form
    {
        public Quản_lí_khách_hàng()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Quản_lí_khách_hàng_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            ptb_Logo.BackColor = Color.Transparent;
            sv.LoadKH(dataGridView1, null);
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new Quản_lí_nhân_viên());
        }

        private void btn_QLNH_Click(object sender, EventArgs e)
        {
            //QUản lí nhập hàng
            Services.ShowForm(this, new ImportHistory());
        }

        private void btn_QLGG_Click(object sender, EventArgs e)
        {
            //    Chưa có form 
            //    Services.ShowForm(this, new )
        }

        private void btn_Quanlicoso_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new Quản_lí_cơ_sở());

        }

        private void btn_Quanlithongke_Click(object sender, EventArgs e)
        {
            // CHưa có form
        }

        private void btn_IH_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new InvoiceHistory());
        }
        private void btn_QLSP_Click(object sender, EventArgs e)
        {

            Services.ShowForm(this, new Quản_lí_sản_phẩm());
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new GioHangCho());
        }
        GetById getById = new GetById();
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (ServicesGlobalVariables.customerid == null)
            {
                MessageBox.Show("Xoa khong thanh cong");
            }
            else
            {
                sv.xoacustomer(getById.GetCustomerById1(ServicesGlobalVariables.customerid));
            }
        }
        QuanlikhachhangServices sv = new QuanlikhachhangServices();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            ServicesGlobalVariables.customerid = Guid.Parse(row.Cells["Id"].Value.ToString());
        }
        private void tb_Timkiem_TextChanged(object sender, EventArgs e)
        {
            sv.LoadKH(dataGridView1, tb_Timkiem.Text);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            AddCustomer cus = new AddCustomer();
            cus.ShowDialog();
        }
    }
}
