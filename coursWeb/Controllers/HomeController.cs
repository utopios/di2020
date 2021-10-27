using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using coursWeb.Models;
using coursWeb.ViewModels;

namespace coursWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //return new ContentResult() { Content = "Bonjour tout le monde" };
            //Pour passer des données du controller vers la vue,
            Person p = new Person() { FirstName = "ihab", LastName = "abadi" };
            List<string> listeStrings = new List<string>() { "toto", "tata", "titi" };
            //On peut utiliser le viewData
            //ViewData["maPersonne"] = p;
            //ViewData["listeStrings"] = listeStrings;
            //On peut utiliser le viewBag
            //ViewBag.MaPersonne = p;
            //ViewBag.ListeStrings = listeStrings;
            HomeViewModel viewModel = new HomeViewModel()
            {
                Person = p,
                ListeStrings = listeStrings
            };
            return View(viewModel);
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

        public IActionResult Toto(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [Route("tata/{param1?}")]
        public IActionResult Tata(string param1)
        {
            return new ContentResult() { Content = param1 };
        }


        public IActionResult Form()
        {
            return View();
        }

        //public IActionResult SubmitForm(string firstName, string lastName)
        public IActionResult SubmitForm([Bind("FirstName","LastName")]Person p)
        {
            //Person p = new Person()
            //{
            //    FirstName = firstName,
            //    LastName = lastName
            //};
            return RedirectToAction("Index");
        }
    }
}
