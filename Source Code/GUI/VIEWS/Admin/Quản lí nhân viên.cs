using ShopNow.Source_Code.BUS.SERVICES;
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
    public partial class Quản_lí_nhân_viên : Form
    {
        public Quản_lí_nhân_viên()
        {
            InitializeComponent();
        }

        private void Quản_lí_nhân_viên_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            ptb_Logo.BackColor = Color.Transparent;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new GioHangCho());
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }
    }
}
