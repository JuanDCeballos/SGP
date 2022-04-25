using System;

namespace SGP.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Genero { get; set; }

        public int TipoDoc { get; set; }

        public string Documento { get; set; }

        public int IdPrograma { get; set; }

        public string Email { get; set; }

        public int Telefono { get; set; }

        public int Rol { get; set; }

        public string Direccion { get; set; }

        public string Pw { get; set; }

        public bool Egresado { get; set; } 
    }
}