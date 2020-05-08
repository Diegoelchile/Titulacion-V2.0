using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto_SEBET.Controllers
{
    public class AreasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}