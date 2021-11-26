using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMigrantHack38.App.Dominio.Entidades
{
    public class Migrante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string PaisOrigen { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string DirecciónActual { get; set; }
        public string Ciudad { get; set; }
        public string SituacionLaboral { get; set; }
    }
}