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

namespace ShopNow.Source_Code.GUI.VIEWS.Customer
{
    public partial class DeliveryInformation : Form
    {
        public DeliveryInformation()
        {
            InitializeComponent();

        }
        private void DeliveryInformation_Load(object sender, EventArgs e)
        {
            txt_Name.Text = getById.GetUserById(ServicesGlobalVariables.userId).Username;
            var customer = getById.GetCustomerById(ServicesGlobalVariables.userId);
            txt_PhoneNumber.Text = customer.PhoneNumber;
            txt_Address.Text = customer.Address;

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ServicesSalesOperations ServicesSalesOperations = new ServicesSalesOperations();
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ServicesSalesOperations.Payment());
            
            this.Close();
        }
        GetById getById = new GetById();
        

    }
}
