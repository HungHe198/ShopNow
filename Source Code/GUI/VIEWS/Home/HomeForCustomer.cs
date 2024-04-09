using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.GUI.VIEWS.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNow.Source_Code.GUI.VIEWS.Home
{
    public partial class HomeForCustomer : Form
    {
        public HomeForCustomer()
        {
            InitializeComponent();
        }





        private void HomeForCustomer_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            ptb_Logo.BackColor = Color.Transparent;


        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new ChoiceLogin());
        }
    }
}
