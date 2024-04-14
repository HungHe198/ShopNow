using ShopNow.Source_Code.BUS.SERVICES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.VIEWS.Staff
{
    public partial class QuanLiKhachHang : Form
    {
        public QuanLiKhachHang()
        {
            InitializeComponent();
        }
        QuanlikhachhangServices sv = new QuanlikhachhangServices();
        private void QuanLiKhachHang_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            ptb_Logo.BackColor = Color.Transparent;
            sv.LoadKH(dataGridView1, null);
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {

            Services.ShowForm(this, new GioHangCho());
        }

        private void btn_QLKH_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }
    }
}
