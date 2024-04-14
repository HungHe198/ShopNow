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

namespace ShopNow.Source_Code.GUI.VIEWS.Staff
{
    public partial class GioHangCho : Form
    {
        public GioHangCho()
        {
            InitializeComponent();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {

        }

        private void btn_QLKH_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new QuanLiKhachHang());
        }
        Guid billId;
        ServicesSalesOperations operations = new ServicesSalesOperations();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var bill = GetById.GetBillById(ServicesGlobalVariables.billId);
            if (bill.Status == 1)
            {
                MessageBox.Show("Bạn đã chọn đơn hàng không hợp lệ\n(Đơn hàng có thể đã được xác nhận hoặc bạn chưa chọn đơn hàng)");
            }
            else
            {
                MessageBox.Show(operations.XacNhanDon(ServicesGlobalVariables.billId));
                billId = Guid.Empty;
                operations.LoadHoaDon(this.dataGridView1, 0);
            }
        }
        GetById GetById = new GetById();
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var bill = GetById.GetBillById(ServicesGlobalVariables.billId);
            if (bill.Status == 1)
            {
                MessageBox.Show("Bạn đã chọn đơn hàng không hợp lệ\n(Đơn hàng có thể đã được xác nhận hoặc bạn chưa chọn đơn hàng)");
            }
            else
            {
                DialogResult = MessageBox.Show("Bạn chắc chắn chứ? (y/n)", null, MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    bill.Status = 0;
                    bill.Deleted = true;
                    operations.LoadHoaDon(this.dataGridView1, 0);
                }
            }
        }
    }
}
