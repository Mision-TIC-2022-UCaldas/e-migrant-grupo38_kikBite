using System;
using System.Collections.Generic;
using EMigrantHack38.App.Dominio;
using System.Linq;

namespace EMigrantHack38.App.Persistencia
{
    public class RepositorioMigrante : IRepositorioMigrante
    {
        private readonly AppContext _appContext;
        public RepositorioMigrante(AppContext appContext)
        {
            _appContext = appContext;
        }
        Migrante IRepositorioMigrante.AddMigrante(Migrante migrante)
        {
            var migranteAdicionado = _appContext.Migrantes.Add(migrante);
            _appContext.SaveChanges();
            return migranteAdicionado.Entity;
        }
    }

}