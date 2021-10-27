using System;
using System.Collections.Generic;

namespace CompteBancaire.Classes
{
    public class Banque
    {
        public Banque()
        {
        }



        public Client CreationClient(string nom, string prenom, string telephone)
        {
            Client client = new Client(nom, prenom, telephone);
            if (client.Save())
            {
                return client;
            }
            return null;
        }

        public Compte CreationCompte(Client client, decimal solde = 0)
        {
            Compte compte = new Compte(solde);
            compte.Client = client;
            compte.ADecouvert += NotificationDecouvert;
            if(compte.Save())
            {
                return compte;
            }
            return null;
        }

        public Compte RechercherCompte(int n)
        {
            return Compte.GetCompteById(n);
        }


        public void NotificationDecouvert(int numeroCompte, decimal solde)
        {
            Console.WriteLine($"Attention le numéro de compte {numeroCompte} est à decouvert de {solde}euros");
        }
    }
}
