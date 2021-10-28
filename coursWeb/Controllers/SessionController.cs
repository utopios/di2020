using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coursWeb.Controllers
{
    public class SessionController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult EcrireDansSession(string id)
        {
            //Le controler a une propriété qui permet d'accéder au context http
            //pour ecrire dans les sessions on peut utliser la méthode setString
            HttpContext.Session.SetString("cle", id);

            return new ContentResult() { Content = "Données ajoutées dans la session" };
        }

        public IActionResult LireApartirDeLaSession()
        {
            //Lire les données dans une session.
            //On utilise HttpContext
            string data = HttpContext.Session.GetString("cle");

            //Pour supprimer une session
            //HttpContext.Session.Clear();
            return new ContentResult() { Content = data };
        }
    }
}
