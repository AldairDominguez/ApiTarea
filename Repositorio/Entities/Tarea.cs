
namespace Repositorio.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
