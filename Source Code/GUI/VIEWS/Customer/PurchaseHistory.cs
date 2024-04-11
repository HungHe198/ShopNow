using ShopNow.Models;
using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using ShopNow.Source_Code.GUI.VIEWS.Home;
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
    public partial class PurchaseHistory : Form
    {
        public PurchaseHistory()
        {
            InitializeComponent();
        }
        ServicesSalesOperations operations = new ServicesSalesOperations();
        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            ptb_Logo.BackColor = Color.Transparent;
            operations.LoadHoaDon(this.dataGridView1, 1);
        }

        private void ptb_Logo_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new HomeForCustomer());

        }
    }
}
