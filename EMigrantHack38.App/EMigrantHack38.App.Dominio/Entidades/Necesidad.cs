using System;

namespace EMigrantHack38.App.Dominio
{

 public class Necesidad
    {
        public int Id { get; set; }
        public Migrante Migrante  { get; set; }
        public ListCategorias Categoria {get; set;}
        public string Descripcion {get;set;}
        public string Prioridad {get;set;}

    }

}