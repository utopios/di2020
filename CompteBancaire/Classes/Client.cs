using System;
namespace CompteBancaire.Classes
{
    public class Client
    {
        private string nom;
        private string prenom;
        private string telephone;
        

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public Client(string n, string p, string t)
        {
            Nom = n;
            Prenom = p;
            Telephone = t;
        }

        public override string ToString()
        {
            return $"Nom : {Nom}, Prénom : {Prenom}, Tel : {Telephone}";
        }
    }
}
