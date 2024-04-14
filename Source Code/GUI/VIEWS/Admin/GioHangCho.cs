using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.VIEWS.Admin
{
    public partial class GioHangCho : Form
    {
        public GioHangCho()
        {
            InitializeComponent();
        }
        ServicesSalesOperations operations = new ServicesSalesOperations();
        private void GioHangCho_Load(object sender, EventArgs e)
        {
            operations.LoadHoaDon(this.dataGridView1, 0);
        }
        Guid billId;
        GetById GetById = new GetById();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // cell click sẽ lấy bill id, nếu xác nhận bill thì sẽ đổi trạng thái từ 0 thành 1
            // hiển thị bên người dùng hóa đơn sẽ hiện trạng thái đang chờ và đã xác nhận với hai trạng thái tương ứng
            if (e.RowIndex != -1)
            {
                // Đảm bảo rằng ô hiện tại không phải là null
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    // Lấy hàng đầu tiên được chọn

                    // Giả sử cột chứa billId có tên là "Id"
                    ServicesGlobalVariables.billId = Guid.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                }
            }
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new GioHangCho());
        }

        private void grb_Quanlinhanvien_Enter(object sender, EventArgs e)
        {

        }
    }
}
