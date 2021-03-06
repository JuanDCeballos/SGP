using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SGP.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Entrevista = new HashSet<Entrevistum>();
            Homologacions = new HashSet<Homologacion>();
            Pagos = new HashSet<Pago>();
        }

        public int IdUsuario { get; set; }

        [Required]
        [MinLength(5)]
        public string Nombre { get; set; }

        [Required]
        [MinLength(5)]
        public string Apellido { get; set; }
        public int? Genero { get; set; }
        public int? TipoDoc { get; set; }

        [Required]
        [MinLength(10)]
        public string Documento { get; set; }
        public int? IdPrograma { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public int? Telefono { get; set; }
        public int? Rol { get; set; }
        public string Direccion { get; set; }
        public string Pw { get; set; }
        public bool? Egresado { get; set; }

        public virtual Genero GeneroNavigation { get; set; }
        public virtual ProgramaUsuario IdProgramaNavigation { get; set; }
        public virtual Rol RolNavigation { get; set; }
        public virtual TipoDocumento TipoDocNavigation { get; set; }
        public virtual ICollection<Entrevistum> Entrevista { get; set; }
        public virtual ICollection<Homologacion> Homologacions { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
