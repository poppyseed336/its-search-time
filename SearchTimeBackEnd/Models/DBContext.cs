namespace SearchTimeBackEnd.Models
{
    using Microsoft.EntityFrameworkCore;
    using System;

    public class DBContext
    {
        public DBContext() { }

        public DbSet<SearchResultItem> SearchResultItems { get; set; }
    }
}
