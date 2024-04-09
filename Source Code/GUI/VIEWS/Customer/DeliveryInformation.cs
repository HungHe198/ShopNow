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

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            // tiến hành lưu vào bảng bill sau đó lấy bill id và lưu vào bảng bill details
        }
        GetById getById = new GetById();
        
    }
}
