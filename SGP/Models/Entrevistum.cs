using System;
using System.Collections.Generic;

#nullable disable

namespace SGP.Models
{
    public partial class Entrevistum
    {
        public int IdEntrevista { get; set; }
        public DateTime? FechaEntrevista { get; set; }
        public string Estado { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
