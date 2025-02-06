namespace SearchTimeBackEnd.Models
{
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=localhost,1433;Database=SearchTimeBackEnd;User Id=sa;Password=suchaS+r0ngp@ssword;ConnectRetryCount=0;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<SearchResultItem>().HasData(
                new SearchResultItem { Id = 1167, Title = "Guitar", Color = "blue" },
                new SearchResultItem { Id = 9992, Title = "Video Game", Color = "green" },
                new SearchResultItem { Id = 2424, Title = "Dinosaur", Color = "red" },
                new SearchResultItem { Id = 6552, Title = "Dress", Color = "purple" },
                new SearchResultItem { Id = 7777, Title = "Planet", Color = "red" },
                new SearchResultItem { Id = 1010, Title = "President", Color = "orange" },
                new SearchResultItem { Id = 1011, Title = "Chapstick", Color = "red" },
                new SearchResultItem { Id = 3360, Title = "Food", Color = "red" },
                new SearchResultItem { Id = 1919, Title = "Beverage", Color = "green" },
                new SearchResultItem { Id = 2123, Title = "Lifeguard", Color = "red" },
                new SearchResultItem { Id = 6666, Title = "Tunnel", Color = "purple" }
            );
        }

        public DbSet<SearchResultItem> SearchResultItems { get; set; }
    }
}
