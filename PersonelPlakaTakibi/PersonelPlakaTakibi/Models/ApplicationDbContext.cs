using Microsoft.EntityFrameworkCore;

namespace PersonelPlakaTakibi.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@".......");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
