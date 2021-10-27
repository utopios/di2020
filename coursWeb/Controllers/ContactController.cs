using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coursWeb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coursWeb.Controllers
{
    public class ContactController : Controller
    {
        //Action pour afficher la liste des contacts
        public IActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View(Contact.GetContacts());
        }

        [Route("afficher-contact/{id?}")]
        public IActionResult DisplayContact(int id)
        {
            return View("contact", Contact.GetContact(id));
        }
        [Route("supprimer-contact/{id?}")]
        public IActionResult DeleteContact(int id)
        {
            Contact contact = Contact.GetContact(id);
            if(contact != null)
            {
                contact.Delete();
            }
            return RedirectToAction("Index", "Contact", new { message = "message suppression"});
        }

        public IActionResult FormContact()
        {
            return View("form");
        }
    }
}
