using ShopNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{

    public class GetById
    {
        PRO131_EFContext context = new PRO131_EFContext();

        public BillDetail GetBillDetailById(Guid guid)
        {
            var Record = context.BillDetails.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }
        public Bill GetBillById(Guid guid)
        {
            var Record = context.Bills.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }
        public CartProduct GetCartProductById(Guid Cartguid, Guid productGuid )
        {
            var Record = context.CartProducts.FirstOrDefault(bd => (bd.CartId == Cartguid) && (bd.ProductId == productGuid) );
            return Record == null ? null : Record;
        }

        public Cart GetCartById(Guid guid)
        {
            var Record = context.Carts.FirstOrDefault(bd => bd.UserId == guid);
            return Record == null ? null : Record;
        }

        public Customer GetCustomerById(Guid guid)
        {
            var Record = context.Customers.FirstOrDefault(bd => bd.UserId == guid);
            return Record == null ? null : Record;
        }

        public CustomerType GetCustomerTypeById(Guid guid)
        {
            var Record = context.CustomerTypes.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }
        public Discount GetDiscount(Guid guid)
        {
            var Record = context.Discounts.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }

        public Employee GetEmployeeById(Guid guid)
        {
            var Record = context.Employees.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }

        public Facility GetFacilityById(Guid guid)
        {
            var Record = context.Facilities.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }

        public ImportHistory GetImportHistoryById(Guid guid)
        {
            var Record = context.ImportHistories.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }
        public Product GetProductById(Guid? guid)
        {
            var Record = context.Products.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }
        public ProductDetail GetProductDetailById(Guid guid)
        {
            var Record = context.ProductDetails.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }
        public Role GetRoleById(Guid guid)
        {
            var Record = context.Roles.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }
        public Supplier GetSupplierById(Guid guid)
        {
            var Record = context.Suppliers.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }
        public User GetUserById(Guid guid)
        {
            var Record = context.Users.FirstOrDefault(bd => bd.Id == guid);
            return Record == null ? null : Record;
        }
        public User GetUserByUserName(string UserName)
        {
            var User = context.Users.FirstOrDefault(u => u.Username == UserName && u.Deleted == false) ;
            return User == null ? null : User;
        }





    }
}
