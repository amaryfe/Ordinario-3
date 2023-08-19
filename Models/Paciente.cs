using System;

namespace Ordinario.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Especie { get; set; }
        public string? Raza { get; set; }
        public int Peso {get; set;}
        public DateTime FechaNacimiento { get; set; }
    }
}