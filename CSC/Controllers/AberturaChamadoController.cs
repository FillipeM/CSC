using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Controllers
{
    public class AberturaChamadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
