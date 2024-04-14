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

namespace ShopNow.Source_Code.GUI.VIEWS.Staff
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        QuanlikhachhangServices services = new QuanlikhachhangServices();
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string UserName = txt_Username.Text;
            string Password = txt_password.Text;
            string Tenkhachhang = txt_CustomerName.Text;
            string sodienthoai = txt_sdt.Text;
            string email = txt_email.Text;
            string diachi = txt_diachi.Text;
            Guid CustomerID = Guid.NewGuid();
            Guid UserID = Guid.NewGuid();
            Models.Customer customer = new Models.Customer() { Id = CustomerID, Name = Tenkhachhang, Address = diachi, Email = email, PhoneNumber = sodienthoai, CreatedTime = DateTime.Now };
            Models.User user = new Models.User() { Id = UserID, Username = UserName, Password = Password, Deleted = false, CreatedTime = DateTime.Now };
            if (services.themUser(user) == "Succes")
            {
                if (services.themCustomer(customer) == "Succes")
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
            }
            else
            {
                MessageBox.Show("Them that bai");
            }

        }
    }
}
