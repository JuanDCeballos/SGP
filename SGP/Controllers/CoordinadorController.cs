using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGP.Controllers
{
    public class CoordinadorController : Controller
    {
        public IActionResult Consulta()
        {
            return View();
        }

        public IActionResult Entrevistas()
        {
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
    }
}