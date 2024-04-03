using ShopNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.Source_Code.DAL.REPOSITORIES
{
    class Repo_GetAll
    {
        PRO131_EFContext _db = new PRO131_EFContext();
        public List<Product> GetAllProducts(string name = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                // Trả về tất cả sản phẩm chưa bị xóa
                return _db.Products.Where(p => p.Deleted == false).ToList();
                // khi bị xóa trường deleted sẽ được chuyển về true và cập nhật ngày được xóa và người xóa
            }
            else
            {
                // Trả về sản phẩm có tên gần giống và chưa bị xóa
                return _db.Products
                           .Where(p => p.ProductName.Contains(name) && p.Deleted == false)
                           .ToList();
            }
        }

        public List<Bill> GetAllBill()
        {
            return _db.Bills.Where(b=>b.Deleted == false).ToList();
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
            return _db.Discounts.Where(d => d.Deleted == false).ToList();

        }
        public List<Employee> GetAllEmployees()
        {
            return _db.Employees.Where(e => e.Deleted == false).ToList();
        }
        public List<Facility> GetAllFacilities()
        {
            return _db.Facilities.Where(f => f.Deleted == false).ToList();
        }
        public List<ImportHistory> GetAllImportHistories()
        {
            return _db.ImportHistories.Where(ih => ih.Deleted == false).ToList();

        }
        public List<ProductDetail> GetAllProductDetails()
        {
            return _db.ProductDetails.Where(pd => pd.Deleted == false).ToList();
        }
        public List<Role> GetAllRoles()
        {
            return _db.Roles.ToList();
        }
        public List<Supplier> GetAllSuppliers()
        {
            return _db.Suppliers.Where(s => s.Deleted == false).ToList();
        }
        public List<User> GetAllUser()
        {
            return _db.Users.Where(b => b.Deleted == false).ToList();
        }
    }
}
