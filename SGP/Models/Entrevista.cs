using System;

namespace SGP.Models
{
    public class Entrevista
    {
        public int IdEntrevista { get; set; }

        public DateTime FechaEntrevista { get; set; }

        public string Estado { get; set; }

        public int IdUsuario { get; set; }
    }
}