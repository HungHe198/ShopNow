using Microsoft.VisualBasic.ApplicationServices;
using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.GUI.Thongke;
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
    public partial class LoginAdmin : Form
    {
        ServiceLoginAD ServiceLoginADs = new ServiceLoginAD();

        public LoginAdmin()
        {
            InitializeComponent();
        }


        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new ChoiceLogin());
        }

        private void btn_loginAD_Click(object sender, EventArgs e)
        {
            Services.ShowForm(this, new HomeForAdmin());
        }

        
    }
}
    
