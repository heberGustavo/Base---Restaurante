using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurantes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantes.Controllers
{
    public class MesasController : Controller
    {
        public IActionResult EmAtendimento()
        {
            return View();
        }

        public IActionResult Disponiveis()
        {
            return View();
        }

        public IActionResult Gerenciamento()
        {
            return View();
        }
    }
}
