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
    public partial class SuaCustom : Form
    {
        public SuaCustom()
        {
            InitializeComponent();
        }
        GetById getById = new GetById();
        Customer_Repository Customer_Repository = new Customer_Repository();
        private void btn_luu_Click(object sender, EventArgs e)
        {
            var result = getById.GetCustomerById(ServicesGlobalVariables.customerid);
            if (result == null) 
            {
                MessageBox.Show("Không thể sửa"); 
                this.Close(); return;
            }
            else
            {
                result.Name = txt_CustomerName.Text;
                result.Email = txt_email.Text;
                result.Address = txt_diachi.Text;
                result.PhoneNumber = txt_sdt.Text;
                if (Customer_Repository.IsUpdateCustomer(result))
                    {
                    MessageBox.Show("Sửa thành công");
                    }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            this.Close ();
        }
    }
}
