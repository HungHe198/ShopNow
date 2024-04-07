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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }
        ServicesSalesOperations operations = new ServicesSalesOperations();
        
        Guid CartId;
        Guid ProductId;

        public Guid userId = new Guid("B053BF55-10F5-EE11-BCA0-103D1C86EA3D");// lấy userId từ formLogin

        private void Cart_Load(object sender, EventArgs e)
        {
            //LoadDataGridView của giỏ hàng
            operations.LoadCart(this.dgvMainCart, userId);

            btn_Save.Enabled = false;
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                if ((Convert.ToInt32(txt_Quantity.Text) == 0) || string.IsNullOrEmpty(txt_Quantity.Text))
                {
                    // chuyeern deleted veef true
                }
                else
                {
                    //Luu so luong moi
                }

            }
            catch (Exception ex)
            {

            }
            btn_Save.Enabled = false;
        }

      

        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {

                btn_Save.Enabled = true;
            }
            catch (Exception ex)
            {
                btn_Save.Enabled = false;
            }
        }

        private void dgvMainCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
