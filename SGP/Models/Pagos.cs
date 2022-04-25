using System;

namespace SGP.Models
{
    public class Pagos
    {
        public int IdPago { get; set; }

        public DateTime Fecha { get; set; }

        public int Valor { get; set; }

        public string ComprobantePago { get; set; }

        public int IdUsuario { get; set; }
    }
}