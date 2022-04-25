using System;

namespace SGP.Models
{
    public class Programacion
    {
        public int IdProgramacion { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Blque { get; set; }

        public string Salon { get; set; }

        public string Semestre { get; set; }

        public int IdModulo { get; set; }
    }
}