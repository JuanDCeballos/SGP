using Microsoft.AspNetCore.Mvc;
using SGP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGP.Controllers
{
    public class CoordinadorController : Controller
    {
        private SGPContext context;

        public CoordinadorController(SGPContext contexto)
        {
            context = contexto;
        }

        public IActionResult Consulta()
        {
            Usuario us = new Usuario();
            return View(us);
        }

        [HttpPost]
        public IActionResult Consulta(Usuario usuario)
        {
            var buscarUsuario = context.Usuarios.Where(u => u.Documento.Contains(usuario.Documento) && u.Rol == 3);

            if (buscarUsuario != null)
            {
                return View(buscarUsuario.FirstOrDefault());
            }
            return View();
        }

        public IActionResult Entrevistas()
        {
            Usuario us = new Usuario();
            return View(us);
        }

        [HttpPost]
        public IActionResult Entrevistas(Usuario usuario)
        {
            var buscarUsuario = context.Usuarios.Where(u => u.Documento.Contains(usuario.Documento));

            if (buscarUsuario != null)
            {
                return View(buscarUsuario.FirstOrDefault());
            }
            return View();
        }

        public IActionResult Homologar()
        {
            return View();
        }

        public IActionResult ProgramarAsignaturas()
        {
            return View();
        }

        public IActionResult Coordinador()
        {
            return View();
        }
    }
}