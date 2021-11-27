using System;

namespace EMigrantHack38.App.Dominio
{
    public class Migrante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string PaisOrigen { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string DireccionActual { get; set; }
        public string Ciudad { get; set; }
        public SituacionLaboral SituacionLaboral { get; set; }
    }
}