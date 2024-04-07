
using ShopNow.Source_Code.BUS.SERVICES;
using ShopNow.Source_Code.GUI.VIEWS.Customer;
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
    public partial class formTrong : Form
    {
        public formTrong()
        {
            InitializeComponent();
        }
        Services Services = new Services();
        private void formTrong_Load(object sender, EventArgs e)
        {
            Services.ShowForm(this, new Cart());
        }
    }
}
