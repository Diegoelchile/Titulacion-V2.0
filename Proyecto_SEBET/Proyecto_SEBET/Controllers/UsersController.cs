using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto_SEBET.Models;

namespace Proyecto_SEBET.Controllers
{
    public class UsersController : Controller
    {
        private IRepository repository;

        public UsersController(IRepository repo) => repository = repo;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User newUser)
        {
            repository.RegisterUser(newUser);
            return RedirectToAction(nameof(Registry));
        }
    }
}