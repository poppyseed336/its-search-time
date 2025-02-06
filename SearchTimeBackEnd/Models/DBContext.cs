namespace SearchTimeBackEnd.Models
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;
    using System;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

        public DbSet<SearchResultItem> SearchResultItems { get; set; }
    }
}
