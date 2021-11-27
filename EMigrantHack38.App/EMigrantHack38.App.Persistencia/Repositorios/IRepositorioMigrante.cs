using System;
using System.Collections.Generic;
using System.Linq;
using EMigrantHack38.App.Dominio;

namespace EMigrantHack38.App.Persistencia
{
    public interface IRepositorioMigrante{
        Migrante AddMigrante(Migrante migrante);
    }
}