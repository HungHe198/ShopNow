using ShopNow.Source.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Product GetProductById(Guid id) 
        {  return _db.Products.Find(x => x.Id == id  ); }
    }
}
