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
    public partial class Quản_lí_nhân_viên : Form
    {
        public Quản_lí_nhân_viên()
        {
            InitializeComponent();
        }

        private void Quản_lí_nhân_viên_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);

        }
    }
}
