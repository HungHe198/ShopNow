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
    public partial class Quản_lí_cơ_sở : Form
    {
        public Quản_lí_cơ_sở()
        {
            InitializeComponent();
        }

        private void Quản_lí_cơ_sở_Load(object sender, EventArgs e)
        {

        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new Quản_lí_sản_phẩm());
        }

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new Quản_lí_nhân_viên());
        }

        private void btn_QLNH_Click(object sender, EventArgs e)
        {

        }

        private void btn_QLGG_Click(object sender, EventArgs e)
        {

        }

        private void btn_Quanlicoso_Click(object sender, EventArgs e)
        {

        }

        private void btn_Quanlithongke_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
