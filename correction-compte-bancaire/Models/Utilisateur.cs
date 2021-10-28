using System;
namespace correction_compte_bancaire.Models
{
    public class Utilisateur
    {

        private string login;
        private string password;
        public Utilisateur()
        {
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public static Utilisateur GetUserLogin(string l, string p)
        {
            Utilisateur user = null;

            //Faire une compraison dans la base de données.
            //Pour simplifier le developpement, je fais une comparaison avec des données statiques.
            if(l == "toto" && p == "tata")
            {
                user = new Utilisateur()
                {
                    Login = l,
                    Password = p
                };
              
            }
            return user;
        }
    }
}
