using Microsoft.EntityFrameworkCore;

namespace ConsoleApp_EF.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-CM8LNK7\\SQLEXPRESS;Initial Catalog=UserDataBase;Trusted_Connection=True");
        }
    }
}
