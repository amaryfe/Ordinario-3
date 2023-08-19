using System;

namespace Ordinario.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public string MotivoVisita { get; set; }
        public string NombreVeterinario { get; set; }
        public DateTime FechaReservada { get; set; }
        public DateTime? FechaAtencion { get; set; }
        public string Observaciones { get; set; }
    }
}
