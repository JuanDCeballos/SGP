using Microsoft.AspNetCore.Mvc;
using SGP.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
            ViewBag.Fecha = null;
            ViewBag.Pago = null;

            return View();
        }

        [HttpPost]
        public IActionResult Consulta(Usuario usuario)
        {
            var buscarUsuario = context.Usuarios.Where(u => u.Documento.Contains(usuario.Documento) && u.Rol == 3);

            Usuario aux = new Usuario();
            aux = buscarUsuario.SingleOrDefault();
            Pago listaPagos = context.Pagos.Where(u => u.IdUsuario == aux.IdUsuario).SingleOrDefault();
            Programa listaPrograma = context.Programas.Where(u => u.IdPrograma == aux.IdPrograma).SingleOrDefault();

            ViewBag.ValPrograma = listaPrograma.ValPrograma;
            ViewBag.Pago = listaPagos.Valor;
            ViewBag.Fecha = listaPagos.Fecha;

            if (buscarUsuario != null)
            {
                return View(buscarUsuario.SingleOrDefault());
            }
            else
            {
                return View();
            }
        }

        public IActionResult Entrevistas()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrevistas(Entrevistum entrevista)
        {
            context.Add(entrevista);
            context.SaveChanges();

            return View();
        }

        public IActionResult Homologar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Homologar(Homologacion homologar)
        {

            context.Add(homologar);
            context.SaveChanges();

            return View();
        }

        public IActionResult ProgramarAsignaturas()
        {
            ViewBag.programa = context.Programas.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult ProgramarAsignaturas(Programacion programacion)
        {
            context.Add(programacion);
            context.SaveChanges();

            ViewBag.programa = context.Programas.ToList();
            return View();
        }

        public IActionResult Coordinador()
        {
            return View();
        }
    }
}