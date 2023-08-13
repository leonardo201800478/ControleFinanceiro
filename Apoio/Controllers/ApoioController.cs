using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Apoio.Controllers
{
    public class ApoioController : Controller
    {
        public IActionResult Empresa()
        {
            ViewData["Title"] = "Controle de Empresas";
            return View();
        }
    }
}
