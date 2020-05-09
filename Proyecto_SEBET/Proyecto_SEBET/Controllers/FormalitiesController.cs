using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto_SEBET.Models;

namespace Proyecto_SEBET.Controllers
{
    public class FormalitiesController : Controller
    {
        private IRepository repository;

        public FormalitiesController(IRepository repo) => repository = repo;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InsertFormality(Formality formality)
        {
            repository.AddFormality(formality);
            return RedirectToAction(nameof(Index));
        }
    }
}