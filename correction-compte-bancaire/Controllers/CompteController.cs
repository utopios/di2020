using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompteBancaire.Classes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace correction_compte_bancaire.Controllers
{
    public class CompteController : Controller
    {
        // GET: /<controller>/
        //Page d'accueil qui affiche le formulaire de recherche
        public IActionResult Index(int? compteId)
        {
            Compte compte = null;
            if(compteId != null)
            {
                compte = Compte.GetCompteById((int)compteId);
            }
            return View(compte);
        }
    }
}
