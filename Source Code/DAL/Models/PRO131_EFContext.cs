using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShopNow.Models
{
    public partial class PRO131_EFContext : DbContext
    {
        public PRO131_EFContext()
        {
        }

        public PRO131_EFContext(DbContextOptions<PRO131_EFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<BillDetail> BillDetails { get; set; } = null!;
        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<CartProduct> CartProducts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerType> CustomerTypes { get; set; } = null!;
        public virtual DbSet<Discount> Discounts { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Facility> Facilities { get; set; } = null!;
        public virtual DbSet<ImportHistory> ImportHistories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductDetail> ProductDetails { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LEVANHUNG\\LEVANHUNG;Initial Catalog=PRO131_EF;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("BILL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.NameCustomer)
                    .HasMaxLength(255)
                    .HasColumnName("NAME_CUSTOMER");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TOTAL_PRICE");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_BILL_CUSTOMER_ID");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BILL_DETAIL");

                entity.Property(e => e.BillId).HasColumnName("BILL_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.HasOne(d => d.Bill)
                    .WithMany()
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_BD_BILL_ID");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_BD_PRODUCTS_ID");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("CART");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CART_USER_ID");
            });

            modelBuilder.Entity<CartProduct>(entity =>
            {
                entity.HasKey(e => new { e.CartId, e.ProductId })
                    .HasName("PK__CART_PRO__8E2AFE19DD410BC3");

                entity.ToTable("CART_PRODUCT");

                entity.Property(e => e.CartId).HasColumnName("CART_ID");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartProducts)
                    .HasForeignKey(d => d.CartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK1_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PK2_ID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("CUSTOMER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.CustomerTypeId).HasColumnName("CUSTOMER_TYPE_ID");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("text")
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.Point)
                    .HasColumnName("POINT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .HasConstraintName("FK_CUSTOMER_CT_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CUSTOMER_USER_ID");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.ToTable("CUSTOMER_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("DISCOUNT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Discount1).HasColumnName("DISCOUNT");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FacilityId).HasColumnName("FACILITY_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("text")
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_EMPLOYEE_FACILITY_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_EMPLOYEE_USERS_ID");
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.ToTable("FACILITY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("text")
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<ImportHistory>(entity =>
            {
                entity.ToTable("IMPORT_HISTORY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .HasColumnName("PRODUCT_NAME");

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.SupplierId).HasColumnName("SUPPLIER_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ImportHistories)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_IH_PRODUCTS_ID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ImportHistories)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_IH_SUPPLIER_ID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("PRODUCTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DiscountId).HasColumnName("DISCOUNT_ID");

                entity.Property(e => e.Display).HasColumnName("DISPLAY");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_NAME");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Ram).HasColumnName("RAM");

                entity.Property(e => e.Rom).HasColumnName("ROM");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Warranty).HasColumnName("WARRANTY");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_PRODUCTS_DISCOUNT_ID");
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.ToTable("PRODUCT_DETAIL");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Camera)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CAMERA");

                entity.Property(e => e.Chip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CHIP");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Color)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Display).HasColumnName("DISPLAY");

                entity.Property(e => e.Memory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MEMORY");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.OperatingSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OPERATING_SYSTEM");

                entity.Property(e => e.Pin).HasColumnName("PIN");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Ram).HasColumnName("RAM");

                entity.Property(e => e.UrlImage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("URL_IMAGE");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_PD_PRODUCTS_ID");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("SUPPLIER");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("text")
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_SUPPLIER_EMPLOYEE_ID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_TIME");

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).HasColumnName("DELETED_BY");

                entity.Property(e => e.DeletedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETED_TIME");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_TIME");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_USERS_ROLES_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
