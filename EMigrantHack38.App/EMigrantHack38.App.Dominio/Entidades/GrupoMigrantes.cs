namespace EMigrantHack38.App.Dominio.Entidades
{
    public class GrupoMigrantes
    {
        public int Id { get; set; }
        public string NombreGrupo{ get; set; }
        public Migrante Integrantes { get; set; }
    }
}