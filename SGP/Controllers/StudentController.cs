using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGP.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ActualizarInformacion()
        {
            return View();
        }

        public IActionResult PagoMatricula()
        {
            return View();
        }

        public IActionResult Student()
        {
            return View();
        }
    }
}
