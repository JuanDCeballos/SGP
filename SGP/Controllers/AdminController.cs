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

        public AdminController(SGPContext context) {
            context = context;
        }

        public IActionResult AdministrarUsuario()
        {
            return View();
        }

        public IActionResult CrearUsuario()
        {

            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}
