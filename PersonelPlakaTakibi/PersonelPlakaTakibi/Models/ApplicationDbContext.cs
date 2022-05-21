using Microsoft.EntityFrameworkCore;

namespace PersonelPlakaTakibi.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"workstation id=PersonelPlakaTakipDb.mssql.somee.com;packet size=4096;user id=smtuncer123_SQLLogin_1;pwd=zz5qm88typ;data source=PersonelPlakaTakipDb.mssql.somee.com;persist security info=False;initial catalog=PersonelPlakaTakipDb");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
