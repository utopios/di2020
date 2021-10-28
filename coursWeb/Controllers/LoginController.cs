using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coursWeb.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coursWeb.Controllers
{
    public class LoginController : Controller
    {
        private ILogin _loginService;
        public LoginController(ILogin login)
        {
            _loginService = login;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitLogin(string email, string password)
        {
            _loginService.SaveAccessToSession(email, password);
            return RedirectToAction("Index", "Contact");
        }
    }
}
