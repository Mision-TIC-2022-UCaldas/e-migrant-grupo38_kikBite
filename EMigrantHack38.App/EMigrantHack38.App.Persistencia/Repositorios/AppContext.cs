using Microsoft.EntityFrameworkCore;
using EMigrantHack38.App.Dominio;

namespace EMigrantHack38.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Migrante> Migrantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True; Initial Catalog = EMigrantHack38Data; Integrated Security = true;");
                //optionsBuilder.UseSqlServer("Data Source = DTDAGUILAR\\SQLEXPRESS; Trusted_Connection=True; Initial Catalog = Transito4");
                // Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
            }
        }
    }
}