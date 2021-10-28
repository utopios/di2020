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

        public IActionResult FormCompte(string message, bool error = false)
        {
            ViewBag.Error = error;
            ViewBag.Message = message;
            return View();
        }


        public IActionResult SubmitFormCompte([Bind("Nom, Prenom, Telephone")] Client client, decimal solde = 0)
        {
            Compte compte = null;
            if(client.Save())
            {
                compte = new Compte(solde);
                compte.Client = client;
                if(compte.Save())
                {
                   return RedirectToAction("Index");
                }
                return RedirectToAction("FormCompte", "Compte", new { error = true, message = "Erreur d'insertion compte" });
            }
            return RedirectToAction("FormCompte", "Compte", new { error = true, message = "Erreur d'insertion client" });

        }

        public IActionResult Operation(string type, int compteId)
        {
            ViewBag.CompteId = compteId;
            ViewBag.Type = type;
            return View();
        }

        public IActionResult SubmitOperation(string type, int compteId, [Bind("Montant")] Operation operation)
        {
            Compte compte = Compte.GetCompteById(compteId);
            if(type == "retrait")
            {
                operation.Montant *= -1;
                if (!compte.Retrait(operation))
                {
                    return RedirectToAction("Operation", "Compte", new { error = true, Message = "Opération impossible" });
                }
            }
            else if(type == "depot")
            {
                if (!compte.Depot(operation))
                {
                    return RedirectToAction("Operation", "Compte", new { error = true, Message = "Dépôt impossible" });
                }
            }
            return RedirectToAction("Index");
        }
    }
}
