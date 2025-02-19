
namespace SearchTimeBackEnd.Models
{
    using Microsoft.EntityFrameworkCore;
    using SearchTimeBackEnd.Models.Entities;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=search-time-database-container,1433;Database=search-time-database;User Id=sa;Password=suchaS+r0ngp@ssword;ConnectRetryCount=0;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<SearchResultItem>().HasData(
                new SearchResultItem { Id = 1, Title = "Piano", Color = "black" },
                new SearchResultItem { Id = 2, Title = "Video Game", Color = "green" },
                new SearchResultItem { Id = 3, Title = "Beverage", Color = "green" },
                new SearchResultItem { Id = 4, Title = "Tunnel", Color = "purple" },
                new SearchResultItem { Id = 5, Title = "Dress", Color = "purple" },
                new SearchResultItem { Id = 6, Title = "Tunnel", Color = "purple" },
                new SearchResultItem { Id = 7, Title = "Microorganism", Color = "purple" },
                new SearchResultItem { Id = 8, Title = "Bench", Color = "purple" },
                new SearchResultItem { Id = 9, Title = "Monster", Color = "purple" },
                new SearchResultItem { Id = 10, Title = "Gi", Color = "purple" },
                new SearchResultItem { Id = 11, Title = "Guitar", Color = "blue" },
                new SearchResultItem { Id = 12, Title = "Ocean", Color = "blue" },
                new SearchResultItem { Id = 13, Title = "Okra", Color = "blue" },
                new SearchResultItem { Id = 14, Title = "Oscillation", Color = "blue" },
                new SearchResultItem { Id = 15, Title = "Office", Color = "blue" },
                new SearchResultItem { Id = 16, Title = "Octopus", Color = "blue" },
                new SearchResultItem { Id = 17, Title = "Chipmunk", Color = "blue" },
                new SearchResultItem { Id = 18, Title = "Tree", Color = "blue" },
                new SearchResultItem { Id = 19, Title = "Ceiling", Color = "blue" },
                new SearchResultItem { Id = 20, Title = "Eye", Color = "blue" },
                new SearchResultItem { Id = 21, Title = "Toenail", Color = "blue" },
                new SearchResultItem { Id = 22, Title = "Dinosaur", Color = "red" },
                new SearchResultItem { Id = 23, Title = "Planet", Color = "red" },
                new SearchResultItem { Id = 24, Title = "Chapstick", Color = "red" },
                new SearchResultItem { Id = 25, Title = "Food", Color = "red" },
                new SearchResultItem { Id = 26, Title = "Lifeguard", Color = "red" },
                new SearchResultItem { Id = 27, Title = "Tone", Color = "red" },
                new SearchResultItem { Id = 28, Title = "Laptop", Color = "red" },
                new SearchResultItem { Id = 29, Title = "Number", Color = "red" },
                new SearchResultItem { Id = 30, Title = "Book", Color = "red" },
                new SearchResultItem { Id = 31, Title = "Library", Color = "red" },
                new SearchResultItem { Id = 32, Title = "Museum", Color = "red" },
                new SearchResultItem { Id = 33, Title = "Star", Color = "red" },
                new SearchResultItem { Id = 34, Title = "Inkling", Color = "red" },
                new SearchResultItem { Id = 35, Title = "Beast", Color = "red" },
                new SearchResultItem { Id = 36, Title = "Tenor", Color = "red" },
                new SearchResultItem { Id = 37, Title = "Paperwork", Color = "red" },
                new SearchResultItem { Id = 38, Title = "Ghoul", Color = "red" },
                new SearchResultItem { Id = 39, Title = "Car", Color = "red" },
                new SearchResultItem { Id = 40, Title = "Aircraft Carrier", Color = "red" },
                new SearchResultItem { Id = 41, Title = "Balloon", Color = "red" },
                new SearchResultItem { Id = 42, Title = "Party", Color = "red" },
                new SearchResultItem { Id = 43, Title = "System", Color = "red" },
                new SearchResultItem { Id = 44, Title = "Orange", Color = "orange" },
                new SearchResultItem { Id = 45, Title = "Nickelodeon", Color = "orange" },
                new SearchResultItem { Id = 46, Title = "Sea", Color = "orange" },
                new SearchResultItem { Id = 47, Title = "Sunset", Color = "orange" },
                new SearchResultItem { Id = 48, Title = "Color", Color = "orange" },
                new SearchResultItem { Id = 49, Title = "Computer", Color = "orange" },
                new SearchResultItem { Id = 50, Title = "Floor", Color = "orange" },
                new SearchResultItem { Id = 51, Title = "Chair", Color = "orange" },
                new SearchResultItem { Id = 52, Title = "Chicken", Color = "orange" },
                new SearchResultItem { Id = 53, Title = "Orangutan", Color = "orange" },
                new SearchResultItem { Id = 54, Title = "Mohwak", Color = "orange" },
                new SearchResultItem { Id = 55, Title = "Tissue", Color = "orange" },
                new SearchResultItem { Id = 56, Title = "Skull", Color = "orange" },
                new SearchResultItem { Id = 57, Title = "Basement", Color = "orange" },
                new SearchResultItem { Id = 58, Title = "Nintendo", Color = "orange" },
                new SearchResultItem { Id = 59, Title = "President", Color = "orange" },
                new SearchResultItem { Id = 60, Title = "Stamp", Color = "orange" },
                new SearchResultItem { Id = 61, Title = "Basketball", Color = "orange" },
                new SearchResultItem { Id = 62, Title = "Flea", Color = "orange" },
                new SearchResultItem { Id = 63, Title = "Spider", Color = "orange" },
                new SearchResultItem { Id = 64, Title = "Tombstone", Color = "orange" },
                new SearchResultItem { Id = 65, Title = "Fashion Statement", Color = "orange" },
                new SearchResultItem { Id = 66, Title = "Sueprhero", Color = "orange" },
                new SearchResultItem { Id = 67, Title = "Shoe", Color = "orange" },
                new SearchResultItem { Id = 68, Title = "Puppet", Color = "orange" },
                new SearchResultItem { Id = 69, Title = "Design", Color = "orange" },
                new SearchResultItem { Id = 70, Title = "Crystal", Color = "orange" },
                new SearchResultItem { Id = 71, Title = "Finger", Color = "orange" },
                new SearchResultItem { Id = 72, Title = "Toe", Color = "orange" },
                new SearchResultItem { Id = 73, Title = "Sweater", Color = "orange" },
                new SearchResultItem { Id = 74, Title = "String", Color = "orange" },
                new SearchResultItem { Id = 75, Title = "Fabric", Color = "orange" },
                new SearchResultItem { Id = 76, Title = "Craft", Color = "orange" },
                new SearchResultItem { Id = 77, Title = "Glow", Color = "orange" },
                new SearchResultItem { Id = 78, Title = "Ear", Color = "orange" }
            );
        }

        public DbSet<SearchResultItem> SearchResultItems { get; set; }
    }
}
