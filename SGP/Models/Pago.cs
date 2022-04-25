﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SGP.Models
{
    public partial class Pago
    {
        public int IdPago { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Valor { get; set; }
        public string ComprobantePago { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
