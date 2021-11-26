namespace EMigrantHack38.App.Dominio.Entidades
{

    public class Solicitud
    {
        public int Id { get; set; }
        public Migrante Migrante { get; set; }
        public Entidad Entidad { get; set; }
        public Necesidad Necesidad_ { get; set; }
        public Servicio Servicio { get; set; }
        public String FechaSolicitud { get; set; }
        public string EstadoSolictud { get; set; }
        public string EstadoAprobacion { get; set; }

    }

}