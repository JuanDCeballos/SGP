using Microsoft.AspNetCore.Mvc;
using SGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGP.Controllers
{
    public class AdminController : Controller
    {
        
        private SGPContext context;

        public AdminController(SGPContext contexto) {
            context = contexto;
        }

        public IActionResult AdministrarUsuario()
        {
            return View();
        }

        public IActionResult CrearUsuario()
        {
            ViewBag.programa = context.Programas.ToList();
            ViewBag.genero = context.Generos.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.tipoDoc = context.TipoDocumentos.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult CrearUsuario(Usuario usuario)
        {
            context.Add(usuario);
            context.SaveChanges();
            ViewBag.genero = context.Generos.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.programa = context.Programas.ToList();
            ViewBag.tipoDoc = context.TipoDocumentos.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AdministrarUsuario(Usuario usuario)
        {
            var buscarUsuario = context.Usuarios.Where(u => u.Documento.Contains(usuario.Documento)).First();

            return View(buscarUsuario);
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}
