using BlazorAppTutoral.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppTutoral.Data
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().Property(c => c.IsSelected).HasDefaultValue(false);
        }
    }
}
