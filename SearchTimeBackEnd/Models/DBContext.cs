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
                    @"Server=localhost,1433;Database=search-time-sql-container;User Id=sa;Password=suchaS+r0ngp@ssword;ConnectRetryCount=0;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<SearchResultItem>().HasData(
                new SearchResultItem { Title = "Piano", Color = "black" },
                new SearchResultItem { Title = "Video Game", Color = "green" },
                new SearchResultItem { Title = "Beverage", Color = "green" },
                new SearchResultItem { Title = "Tunnel", Color = "purple" },
                new SearchResultItem { Title = "Dress", Color = "purple" },
                new SearchResultItem { Title = "Tunnel", Color = "purple" },
                new SearchResultItem { Title = "Microorganism", Color = "purple" },
                new SearchResultItem { Title = "Bench", Color = "purple" },
                new SearchResultItem { Title = "Monster", Color = "purple" },
                new SearchResultItem { Title = "Gi", Color = "purple" },
                new SearchResultItem { Title = "Guitar", Color = "blue" },
                new SearchResultItem { Title = "Ocean", Color = "blue" },
                new SearchResultItem { Title = "Okra", Color = "blue" },
                new SearchResultItem { Title = "Oscillation", Color = "blue" },
                new SearchResultItem { Title = "Office", Color = "blue" },
                new SearchResultItem { Title = "Octopus", Color = "blue" },
                new SearchResultItem { Title = "Chipmunk", Color = "blue" },
                new SearchResultItem { Title = "Tree", Color = "blue" },
                new SearchResultItem { Title = "Ceiling", Color = "blue" },
                new SearchResultItem { Title = "Eye", Color = "blue" },
                new SearchResultItem { Title = "Toenail", Color = "blue" },
                new SearchResultItem { Title = "Dinosaur", Color = "red" },
                new SearchResultItem { Title = "Planet", Color = "red" },
                new SearchResultItem { Title = "Chapstick", Color = "red" },
                new SearchResultItem { Title = "Food", Color = "red" },
                new SearchResultItem { Title = "Lifeguard", Color = "red" },
                new SearchResultItem { Title = "Tone", Color = "red" },
                new SearchResultItem { Title = "Laptop", Color = "red" },
                new SearchResultItem { Title = "Number", Color = "red" },
                new SearchResultItem { Title = "Book", Color = "red" },
                new SearchResultItem { Title = "Library", Color = "red" },
                new SearchResultItem { Title = "Museum", Color = "red" },
                new SearchResultItem { Title = "Star", Color = "red" },
                new SearchResultItem { Title = "Inkling", Color = "red" },
                new SearchResultItem { Title = "Beast", Color = "red" },
                new SearchResultItem { Title = "Tenor", Color = "red" },
                new SearchResultItem { Title = "Paperwork", Color = "red" },
                new SearchResultItem { Title = "Ghoul", Color = "red" },
                new SearchResultItem { Title = "Car", Color = "red" },
                new SearchResultItem { Title = "Aircraft Carrier", Color = "red" },
                new SearchResultItem { Title = "Balloon", Color = "red" },
                new SearchResultItem { Title = "Party", Color = "red" },
                new SearchResultItem { Title = "System", Color = "red" },
                new SearchResultItem { Title = "Orange", Color = "orange" },
                new SearchResultItem { Title = "Nickelodeon", Color = "orange" },
                new SearchResultItem { Title = "Sea", Color = "orange" },
                new SearchResultItem { Title = "Sunset", Color = "orange" },
                new SearchResultItem { Title = "Color", Color = "orange" },
                new SearchResultItem { Title = "Computer", Color = "orange" },
                new SearchResultItem { Title = "Floor", Color = "orange" },
                new SearchResultItem { Title = "Chair", Color = "orange" },
                new SearchResultItem { Title = "Chicken", Color = "orange" },
                new SearchResultItem { Title = "Orangutan", Color = "orange" },
                new SearchResultItem { Title = "Mohwak", Color = "orange" },
                new SearchResultItem { Title = "Tissue", Color = "orange" },
                new SearchResultItem { Title = "Skull", Color = "orange" },
                new SearchResultItem { Title = "Basement", Color = "orange" },
                new SearchResultItem { Title = "Nintendo", Color = "orange" },
                new SearchResultItem { Title = "President", Color = "orange" },
                new SearchResultItem { Title = "Stamp", Color = "orange" },
                new SearchResultItem { Title = "Basketball", Color = "orange" },
                new SearchResultItem { Title = "Flea", Color = "orange" },
                new SearchResultItem { Title = "Spider", Color = "orange" },
                new SearchResultItem { Title = "Tombstone", Color = "orange" },
                new SearchResultItem { Title = "Fashion Statement", Color = "orange" },
                new SearchResultItem { Title = "Sueprhero", Color = "orange" },
                new SearchResultItem { Title = "Shoe", Color = "orange" },
                new SearchResultItem { Title = "Puppet", Color = "orange" },
                new SearchResultItem { Title = "Design", Color = "orange" },
                new SearchResultItem { Title = "Crystal", Color = "orange" },
                new SearchResultItem { Title = "Finger", Color = "orange" },
                new SearchResultItem { Title = "Toe", Color = "orange" },
                new SearchResultItem { Title = "Sweater", Color = "orange" },
                new SearchResultItem { Title = "String", Color = "orange" },
                new SearchResultItem { Title = "Fabric", Color = "orange" },
                new SearchResultItem { Title = "Craft", Color = "orange" },
                new SearchResultItem { Title = "Glow", Color = "orange" },
                new SearchResultItem { Title = "Ear", Color = "orange" }
            );
        }

        public DbSet<SearchResultItem> SearchResultItems { get; set; }
    }
}
