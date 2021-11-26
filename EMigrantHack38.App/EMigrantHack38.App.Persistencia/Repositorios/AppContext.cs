using Microsoft.EntityFrameworkCore;
using EMigrantHack38.App.Dominio;

namespace MiApp.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Migrante> Migrantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                 optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EMigrantHack38");
                //optionsBuilder.UseSqlServer("Data Source = DTDAGUILAR\\SQLEXPRESS; Trusted_Connection=True; Initial Catalog = Transito4");
                // Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
            }
        }
    }
}