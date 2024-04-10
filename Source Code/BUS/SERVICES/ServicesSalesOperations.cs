using ShopNow.Source_Code.GUI.VIEWS.Customer;
using ShopNow.Source_Code.DAL.REPOSITORIES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopNow.Models;

namespace ShopNow.Source_Code.BUS.SERVICES
{
    public class ServicesSalesOperations
    {
        // tính năng mua hàng chỉ áp dụng cho tài khoản trong bảng customer khi nối qua bảng cart và User
        // Xác định Giỏ hàng của người dùng đó
        // lựa chọn sản phẩm đưa vào bảng cart và cart_product của người dùng
        // nhập thông tin của khách hàng.
        // lựa chọn phương thức thanh toán Nếu không xử lí được thì chỉ cần thanh toán khi nhận hàng.
        // xác nhận đơn hàng, dữ liệu sẽ được để đến form invoiceHistory của admin
        //Nút xác nhận đã nhận hàng sẽ được bật lên để người dùng xác nhận và thanh toán.


        // hiển thị sản phẩm trong giỏ hàng của người dùng (Customer xác định);
        Cart_Repository Cart_Repository = new Cart_Repository();
        Cart_Product_Repository Cart_Product_Repository = new Cart_Product_Repository();
        Product_Repository Product_Repository = new Product_Repository();
        Product_Detail_Repository Product_Detail_Repository = new Product_Detail_Repository();
        Repo_GetAll getAll = new Repo_GetAll();
        GetById GetById = new GetById();
        /* public void LoadCart(DataGridView mainDGV, Guid userId)
         {

             var cartData = (from c in getAll.GetAllCart()
                             //join cp in getAll.GetAllCartProducts() on c.Id equals cp.CartId
                             //join p in getAll.GetAllProducts(null) on cp.ProductId equals p.Id
                             //join pd in getAll.GetAllProductDetails() on p.Id equals pd.ProductId.GetValueOrDefault()
                             where c.UserId == userId
                                   && c.Deleted.GetValueOrDefault() == false
                                   //&& cp.Deleted.GetValueOrDefault() == false
                                   //&& p.Deleted.GetValueOrDefault() == false
                                   //&& cp.Quantity != 0 && p.Quantity != 0
                             select new
                             {
                                 CartId = c.Id,
                                 //ProductId = cp.ProductId,
                                 //ProductName = p.ProductName,
                                 //Price = p.Price.GetValueOrDefault(),
                                 //Quantity = cp.Quantity.GetValueOrDefault(),
                                 //TotalPrice = (double)cp.Quantity.GetValueOrDefault() * (double)p.Price.GetValueOrDefault(),
                                 //UrlImage = pd.UrlImage,
                             }).ToList();
             // Gán BindingList làm DataSource cho DataGridView
             mainDGV.DataSource = cartData;
             //mainDGV.Columns["ProductName"].Width = 472;
             //mainDGV.Columns["Price"].Width = 260;
             //mainDGV.Columns["Quantity"].Width = 100;
             //mainDGV.Columns["TotalPrice"].Width = 260;
             //mainDGV.Columns["CartId"].Visible = false;
             //mainDGV.Columns["ProductId"].Visible = false;


             //mainDGV.Columns["UrlImage"].Visible = false;

         }
        */
        public void LoadCart(DataGridView mainDGV, Guid userId)
        {
            var CartData = from u in getAll.GetAllUser()
                           join c in getAll.GetAllCart() on u.Id equals c.UserId
                           join cp in getAll.GetAllCartProducts() on c.Id equals cp.CartId
                           join p in getAll.GetAllProducts(null) on cp.ProductId equals p.Id
                           join pd in getAll.GetAllProductDetails() on p.Id equals pd.ProductId
                           where c.UserId == userId
                           && c.Deleted.GetValueOrDefault() == false
                           && cp.Deleted.GetValueOrDefault() == false
                           && p.Deleted.GetValueOrDefault() == false
                           && cp.Quantity != 0 && p.Quantity != 0
                           select
                           new
                           {
                               ProductDetailId = pd.Id,
                               CartId = c.Id,
                               ProductId = cp.ProductId,
                               ProductName = p.ProductName,
                               Price = p.Price.GetValueOrDefault(),
                               Quantity = cp.Quantity.GetValueOrDefault(),
                               TotalPrice = (double)cp.Quantity.GetValueOrDefault() * (double)p.Price.GetValueOrDefault(),
                               UrlImage = pd.UrlImage,
                               Color = pd.Color,
                               SoLuongConLai = p.Quantity.GetValueOrDefault(),
                               LuongMua = cp.Quantity,
                           };
            mainDGV.DataSource = CartData.ToList();
            mainDGV.Columns["ProductName"].Width = 472;
            mainDGV.Columns["Price"].Width = 260;
            mainDGV.Columns["Quantity"].Width = 100;
            mainDGV.Columns["TotalPrice"].Width = 260;
            mainDGV.Columns["CartId"].Visible = false;
            mainDGV.Columns["ProductId"].Visible = false;
            mainDGV.Columns["UrlImage"].Visible = false;
            mainDGV.Columns["ProductDetailId"].Visible = false;
            mainDGV.Columns["SoLuongConLai"].Visible = false;
            ////////////////////
            decimal totalPriceSum = 0;
            foreach (DataGridViewRow row in mainDGV.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null)
                {
                    totalPriceSum += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                }
            }
            ServicesGlobalVariables.TotalPrice = totalPriceSum;
            ServicesGlobalVariables.productSaved = CartData
                                                    .AsEnumerable()
                                                    .Select(x => new Product
                                                    {
                                                        Id = x.ProductId,
                                                        ProductName = x.ProductName,
                                                        Price = x.Price,
                                                        Quantity = x.SoLuongConLai,
                                                        
                                                    }).ToList();
        }
        public string IsDelCartProduct(Guid cartId, Guid productId)
        {
            try
            {

                var objDel = GetById.GetCartProductById(cartId, productId);
                if (objDel == null)
                {
                    return "Xóa thất bại";
                }
                else
                {
                    objDel.Deleted = true;

                    if (Cart_Product_Repository.IsUpdateCart_Product(objDel))
                    {
                        return "Xóa thành công";
                    }
                    else return "Xóa thất bại";
                }

            }

            catch (Exception ex) { return "Xóa thất bại"; }


        }
        public string IsUpdateCartProduct(Guid cartId, Guid productId, int Quantity)
        {
            try
            {

                var objUpdate = GetById.GetCartProductById(cartId, productId);
                if (objUpdate == null)
                {
                    return "Sửa thất bại";
                }
                else
                {
                    objUpdate.Quantity = Quantity;
                    if (Cart_Product_Repository.IsUpdateCart_Product(objUpdate))
                    {
                        return "Succes";
                    }
                    else return "Sửa thất bại";
                }

            }

            catch (Exception ex) { return "Xóa thất bại"; }


        }

        Bill_Repository Bill_Repository = new Bill_Repository();
        Bill_Detail_Repository Bill_Detail_Repository = new Bill_Detail_Repository();
        GetById getById = new GetById();
        public string Payment()
        {
            // tiến hành lưu vào bảng bill sau đó lấy bill id và lưu vào bảng bill details
            Guid BillId = Guid.NewGuid();
            Guid BillDetailsId = Guid.NewGuid();
            double TotalPrice = 0;
            var customer = getById.GetCustomerById(ServicesGlobalVariables.userId);
            try
            {
                Bill bill = new Bill() { Id = BillId, CustomerId = customer.Id, NameCustomer = customer.Name, Status = 1, TotalPrice = ServicesGlobalVariables.TotalPrice };
                if (Bill_Repository.IsAddBill(bill))
                {
                    foreach (var product in ServicesGlobalVariables.productSaved)
                    {
                        BillDetail billDetail = new BillDetail();
                        billDetail.Id = Guid.NewGuid();
                        billDetail.ProductId = product.Id;

                        billDetail.BillId = bill.Id;
                        billDetail.Quantity = product.Quantity;
                        billDetail.Price = product.Price;
                        billDetail.CreatedTime = DateTime.Now;
                        if (!Bill_Detail_Repository.IsAddBillDetail(billDetail))
                        {
                            bill.Deleted = true;
                            return "Đặt không thành công";
                        }
                        else
                        {
                            var product1 = getById.GetProductById(billDetail.ProductId);
                            product1.Quantity = product1.Quantity - 
                                                Convert.ToInt32(getById.GetCartProductById(ServicesGlobalVariables.cartId, product.Id).Quantity);
                            if (product1.Quantity == 0)
                            {
                                Product_Repository.isDelProduct(product1);
                            }
                            else if (product1.Quantity >= 1)
                            {

                                Product_Repository.IsUpdateProduct(product1);
                            }
                            var cartproduct = getById.GetCartProductById(ServicesGlobalVariables.cartId, product.Id);
                            cartproduct.Deleted = true;
                        }
                    }
                    return "Đặt thành công";
                }
                else { return "Đặt thất bại"; }
            }
            catch
            {
                { return "Đặt thất bại"; }
            }
        }
    }
}

