using ShopNow.Models;
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
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }
        NhanVienServices NhanVienServices = new NhanVienServices();
        private void button1_Click(object sender, EventArgs e)
        {
            string Username = this.textBox1.Text;
            string Pass = this.textBox2.Text;
            string Name = this.textBox3.Text;
            string Email = this.textBox4.Text;
            Guid UserId = Guid.NewGuid();
            User user = new User() { Id = UserId, Username = Username, Password = Pass, CreatedBy = ServicesGlobalVariables.userId, RoleId = ServicesGlobalVariables.Staff, CreatedTime = DateTime.Now, Deleted = false };
            Employee employee = new Employee() { Id = Guid.NewGuid(), UserId = UserId, Name = Name, CreatedBy = ServicesGlobalVariables.userId};

            if (employee != null)
            {
                MessageBox.Show("Fail");
            }
            else
            {
                MessageBox.Show(NhanVienServices.addNhanVien(employee));
                NhanVienServices.addUser(user);

            }

        }
    }
}
