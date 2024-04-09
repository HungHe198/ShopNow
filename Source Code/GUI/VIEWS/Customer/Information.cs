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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }
        GetById GetById = new GetById();    
        private void Information_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            btn_Save.Enabled = false;

            var user = GetById.GetUserById(ServicesGlobalVariables.userId);
            txt_Name.Text = user.Username;
            txt_Address.Text = user.Address;
            txt_Email.Text = user.Email;
            txt_Password.Text = user.Password;
            txt_PhoneNumber.Text = user.PhoneNumber;
           
        }
        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
