using ShopNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{
    // Giỏ hàng luôn được tạo tự động khi khách hàng tạo tài khoản
    // và mỗi khách hàng chỉ có duy nhất một giỏ hàng
    class Bill_Repository
    {
        PRO131_EFContext context = new PRO131_EFContext();
    }
}
