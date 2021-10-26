using System;
using System.Collections.Generic;

namespace CompteBancaire.Classes
{
    public class Compte
    {
        private decimal solde;
        private int numero;

        public event Action<int, decimal> ADecouvert;

        private static int compteur = 0;
        private Client client;
        private List<Operation> operations;

        public Compte()
        {
            numero = ++compteur;
            Operations = new List<Operation>();
            solde = 0;
        }

        public Compte(decimal s) : this()
        {
            solde = s;
        }

        public decimal Solde { get => solde;}
        public Client Client { get => client; set => client = value; }
        public List<Operation> Operations { get => operations; set => operations = value; }
        public int Numero { get => numero; }

        public virtual bool Depot(Operation o)
        {
            if(o.Montant > 0)
            {
                Operations.Add(o);
                solde += o.Montant;
                return true;
            }
            return false;
        }

        public virtual bool Retrait(Operation o)
        {
            if(o.Montant < 0) {
                Operations.Add(o);
                solde += o.Montant;
                if(solde < 0 && ADecouvert != null)
                {
                    ADecouvert(numero, solde);
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string retour = $"Numero du compte {numero},";
            retour += $"Solde {solde},";
            retour += $"Client {Client}";
            return retour;
        }
    }
}
