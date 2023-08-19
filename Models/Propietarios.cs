namespace Ordinario_3.Models{
public class Propietario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string CorreoElectronico { get; set; }
    public string Telefono { get; set; }
    public List<Cita> Citas { get; set; }
}

public class Cita
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string Descripcion { get; set; }
    public int PropietarioId { get; set; }
    public Propietario Propietario { get; set; }
}
}