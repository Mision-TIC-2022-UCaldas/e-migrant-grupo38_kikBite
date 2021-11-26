using System.Collections.Generic;
using MiApp.Dominio;

namespace EMigrantHack38.App.Persistencia.Repositorios
{
    public interface IRepositorioMigrante{
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);
        Persona GetPersonaXDocumento(string idDocumento);
        IEnumerable<Persona> GetPersonasXAccidente(int idAccidente);
    }
}