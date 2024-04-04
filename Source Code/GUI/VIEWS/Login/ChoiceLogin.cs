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

namespace ShopNow.Source_Code.GUI.VIEWS.Login
{
    public partial class ChoiceLogin : Form
    {
        public ChoiceLogin()
        {
            InitializeComponent();
        }

        private void ChoiceLogin_Load(object sender, EventArgs e)
        {

        }
       
        private void btn_admin_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new LoginAdmin());

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new LoginCustomer());

        }
    }
}
