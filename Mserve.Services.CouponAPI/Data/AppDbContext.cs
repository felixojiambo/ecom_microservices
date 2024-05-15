using Microsoft.EntityFrameworkCore;
using Mserve.Services.CouponAPI.Models;

namespace Mserve.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<Coupon>().HasData(new Coupon
           // { CouponId = 1, CouponCode = "fe3", DiscountAmount = 10, MinAmount = 500 });
           // modelBuilder.Entity<Coupon>().HasData(new Coupon
           // { CouponId = 2, CouponCode = "erhf", DiscountAmount = 60, MinAmount = 999 });
            //modelBuilder.Entity<Coupon>().HasData(new Coupon
            //{ CouponId = 3, CouponCode = "20off", DiscountAmount = 55, MinAmount = 100 });
        }
    }
}