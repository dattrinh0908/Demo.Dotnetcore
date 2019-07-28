using Demo.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :
            base(options)
        {
            
        }
        public virtual DbSet<Footer> Footer { get; set; }

        public virtual DbSet<Menu> Menu { get; set; }

        public virtual DbSet<MenuGroup> MenuGroup { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetail> OrderDetail { get; set; }

        public virtual DbSet<Page> Page { get; set; }

        public virtual DbSet<Post> Post { get; set; }

        public virtual DbSet<PostCategory> PostCategory { get; set; }

        public virtual DbSet<PostTag> PostTag { get; set; }

        public virtual DbSet<Product> Product { get; set; }

        public virtual DbSet<ProductCategory> ProductCategory { get; set; }

        public virtual DbSet<ProductTag> ProductTag { get; set; }

        public virtual DbSet<Slide> Slide { get; set; }

        public virtual DbSet<SupportOnline> SupportOnline { get; set; }

        public virtual DbSet<SystemConfig> SystemConfig { get; set; }

        public virtual DbSet<VisitorStatistic> VisitorStatistic { get; set; }

        public virtual DbSet<Tag> Tag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
            .HasKey(c => new { c.OrderID, c.ProductID });

            modelBuilder.Entity<ProductTag>()
           .HasKey(c => new { c.ProductID, c.TagID });

            modelBuilder.Entity<PostTag>()
           .HasKey(c => new { c.PostID, c.TagID });
        }
    }
}