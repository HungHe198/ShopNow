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
    public partial class PurchaseHistory : Form
    {
        public PurchaseHistory()
        {
            InitializeComponent();
        }

        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml(ServicesGlobalVariables.GlobalBackColor);
            ptb_Logo.BackColor = Color.Transparent;
            LoadData();
        }
        Repo_GetAll getAll = new Repo_GetAll();
        public void LoadData()
        {
            var Result = from b in getAll.GetAllBill()
                         join bd in getAll.GetAllBillDetail()
                         on b.Id equals bd.BillId
                         join p in getAll.GetAllProducts(null)
                         on bd.ProductId equals p.Id
                         select
                         new
                         {
                             TenNguoiNhan = b.NameCustomer,
                             TenSanPham = p.ProductName,
                             SoLuong = bd.Quantity,
                             TongTien = b.TotalPrice,
                         };
            dataGridView1.DataSource  = Result.ToList();
        }
    }
}
