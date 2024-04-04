using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowForm(Form childForm)
        {
            // Đặt form hiện tại là form chủ
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Xóa các controls hiện có và thêm form mới vào
            this.Controls.Clear();
            this.Controls.Add(childForm);
            childForm.Show();
        }

        // Khi cần hiển thị CustomerLoginForm

        // Khi cần hiển thị AdminLoginForm
        private void btnqtv_Click(object sender, EventArgs e)
        {
            ShowForm(new LoginAdmin());

        }

        private void btnkhang_Click(object sender, EventArgs e)
        {
            ShowForm(new LoginCustomer());

        }
    }
}
