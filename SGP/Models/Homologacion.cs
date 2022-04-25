using System;

namespace SGP.Models
{
    public class Homologacion
    {
        public int IdHomologacion { get; set; }

        public DateTime FechaHomologacion { get; set; }

        public string Universidad { get; set; }

        public float Nota { get; set; }

        public int IdPrograma { get; set; }

        public int IdModulo { get; set; }

        public int IdUsuario { get; set; }
    }
}