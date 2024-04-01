using ShopNow.Models;
using ShopNow.Source.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{
    class Repo
    {
        PRO131_EFContext _db = new PRO131_EFContext();
        public List<Product> GetAllProducts()
        {
            return _db.Products.ToList();

        }
        public List<Bill> GetAllBill()
        {
            return _db.Bills.ToList();
        }
        public List<BillDetail> GetAllBillDetail()
        {
            return _db.BillDetails.ToList();

        }
        public List<Cart> GetAllCart()
        {
            return _db.Carts.ToList();

        }
        public List<CartProduct> GetAllCartProducts()
        {

            return _db.CartProducts.ToList();
        }

        public List<Customer> GetAllCustomers()
        {
            return _db.Customers.ToList();
        }

        public List<CustomerType> GetAllCustomerTypes()
        {
            return _db.CustomerTypes.ToList();

        }
        public List<Discount> GetAllDiscounts()
        {
            return _db.Discounts.ToList();

        }
        public List<Employee> GetAllEmployees()
        {
            return (_db.Employees.ToList());
        }
        public List<Facility> GetAllFacilities()
        {
            return _db.Facilities.ToList();
        }
        public List<ImportHistory> GetAllImportHistories()
        {
            return _db.ImportHistories.ToList();

        }
        public List<ProductDetail> GetAllProductDetails()
        {
            return _db.ProductDetails.ToList();
        }
        public List<Role> GetAllRoles()
        { return _db.Roles.ToList(); }
        public List<Supplier> GetAllSuppliers()
        {
            return _db.Suppliers.ToList();
        }
        public List<User> GetAllUser()
        {
            return _db.Users.ToList();
        }
    }
}
