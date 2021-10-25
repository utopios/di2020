using System;
using System.Collections.Generic;

namespace CompteBancaire.Classes
{
    public class Banque
    {
        private List<Compte> comptes;
        public Banque()
        {
        }



        public Client CreationClient(string nom, string prenom, string telephone)
        {
            return new Client(nom, prenom, telephone);
        }

        public Compte CreationCompte(Client client, decimal solde = 0)
        {
            Compte compte = new Compte(solde);
            compte.Client = client;
            return compte;
        }

        public Compte RechercherCompte(int n)
        {
            return comptes.Find(c => c.Numero == n);
        }
    }
}
