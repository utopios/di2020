using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coursWeb.Controllers
{
    public class ContactController : Controller
    {
        //Action pour afficher la liste des contacts
        public IActionResult Index()
        {
            return View();
        }

        [Route("afficher-contact")]
        public IActionResult DisplayContact()
        {
            return View("contact");
        }

        public IActionResult FormContact()
        {
            return View("form");
        }
    }
}
