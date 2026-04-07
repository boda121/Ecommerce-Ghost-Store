using Ghost_T.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyEcommerceAdmin.Models;

namespace Ghost_T.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public virtual DbSet<admin_Employee> admin_Employee { get; set; }
       // public virtual DbSet<admin_Login> admin_Login { get; set; }
        //public virtual DbSet<Payment> Payments { get; set; }
        //public virtual DbSet<PaymentType> PaymentTypes { get; set; }
       // public virtual DbSet<genMainSlider> genMainSliders { get; set; }
        //public virtual DbSet<genPromoRight> genPromoRights { get; set; }
        //public virtual DbSet<Role> Roles { get; set; }
       // public virtual DbSet<Supplier> Suppliers { get; set; }
       // public virtual DbSet<ShippingDetail> ShippingDetails { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orders_Product> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RecentlyView> RecentlyViews { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Ghost_T.Models.Cart> Cart { get; set; } = default!;
    }
}