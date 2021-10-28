using System;
using correction_compte_bancaire.Models;

namespace correction_compte_bancaire.Services
{
    public interface ILogin
    {
        bool isLogged();
        string GetLogin();
        bool LogIn(string login, string password);
    }
}
