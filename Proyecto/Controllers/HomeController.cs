using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto.Data;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;

        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        //get login
        public IActionResult Login()
        {
            return View();
        }

        //post login
        [HttpPost]
        public IActionResult Login(string User, string Pass)
        {
            var usuario = _context.Login.Where(s => s.User == User && s.Pass == Pass);
            if (usuario.Any())
            {
                if (usuario.Where(s => s.User == User && s.Pass == Pass).Any())
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return Json(new { status = false, message = "Datos Incorrectos" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Datos Incorrectos" });
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
