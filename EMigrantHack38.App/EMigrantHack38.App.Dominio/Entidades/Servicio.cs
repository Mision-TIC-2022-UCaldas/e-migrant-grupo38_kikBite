using System;

namespace EMigrantHack38.App.Dominio
{

 public class Servicio
    {
        public int Id { get; set; }
        public ListCategorias Categoria {get; set;}
        public string NombreServicio { get; set; }
        public string Descripcion  { get; set; }
        public int MaxNumMigrantes {get;set;}
        public string FecInicio {get;set;}
        public string FecFinal {get;set;}
        public string EstadoServicio {get;set;}

    }

}