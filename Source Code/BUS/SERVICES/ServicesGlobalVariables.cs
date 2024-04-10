using ShopNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.BUS.SERVICES
{
    public static class ServicesGlobalVariables
    {
        public static Guid userId;
        public static Guid cartId;
        public static Guid Admin = new Guid("984386D1-A3F6-EE11-BCA0-103D1C86EA3D");
        public static Guid Customer = new Guid("994386D1-A3F6-EE11-BCA0-103D1C86EA3D");
        public static string GlobalBackColor = "#ffbe98";

        public static string? productName;
        public static string? color;
        public static decimal price;
        public static int quantity;
        public static float display;
        public static int ram;
        public static int rom;
        public static string memory;
        public static float warranty;
        public static decimal TotalPrice;
        public static string? description;
        public static string? UrlImage;

        public static Guid productId;
        public static Guid productDetailId;
        public static List<Product> productSaved;
    }
}
