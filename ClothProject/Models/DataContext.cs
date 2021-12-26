using Microsoft.EntityFrameworkCore;

namespace ClothProject.Models
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ClothCategory> ClothCategories { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<ClothType> ClothTypes { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
    }
}
