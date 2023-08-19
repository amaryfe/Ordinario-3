namespace Examen.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? Costo { get; set; }
        public string? RequisitosPrevios { get; set; }
    }
}