using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.BUS.SERVICES
{
    class Services
    {
        //public void Test()
        //{ 

        //} 
        public static void ShowForm(Form FatherForm,Form childForm)
        {
            // Đặt form hiện tại là form chủ
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Xóa các controls hiện có và thêm form mới vào
            FatherForm.Controls.Clear();
            FatherForm.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
