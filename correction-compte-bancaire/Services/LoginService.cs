using System;
using correction_compte_bancaire.Models;
using Microsoft.AspNetCore.Http;

namespace correction_compte_bancaire.Services
{
    public class LoginService : ILogin
    {
        private IHttpContextAccessor _accessor;
        public LoginService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string GetLogin()
        {
            return _accessor.HttpContext.Session.GetString("login");
        }

        public bool isLogged()
        {
            string test = _accessor.HttpContext.Session.GetString("isLogged");
            return test == "true";
        }

        public bool LogIn(string login, string password)
        {
            Utilisateur u = Utilisateur.GetUserLogin(login, password);
            if(u != null)
            {
                _accessor.HttpContext.Session.SetString("login", u.Login);
                _accessor.HttpContext.Session.SetString("isLogged", "true");
                return true;
            }
            return false;
        }
    }
}
