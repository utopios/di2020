using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coursWeb.Models;
using coursWeb.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coursWeb.Controllers
{
    public class ContactController : Controller
    {

        private ILogin _loginSevice;

        public ContactController(ILogin login)
        {
            _loginSevice = login;
        }
         //Action pour afficher la liste des contacts
        public IActionResult Index(string message)
        {
            //LoginService loginService = new LoginService(HttpContext.Session);
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

        public IActionResult SubmitForm(Contact contact)
        {
            if(contact.Save())
            {
                return RedirectToAction("Index", "Contact", new { message = "contact ajouté" });
            }
            else
            {
                return View("form");
            }
        }
    }
}
