using Microsoft.EntityFrameworkCore;

namespace GlobaWBNew.Model {
    public class ApplicationContext : DbContext {
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Staff> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=globaWBNewdb;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Server=localhost;Database=globaWBdb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
