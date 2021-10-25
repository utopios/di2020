using System;
namespace CompteBancaire.Classes
{
    public class Operation
    {
        private decimal montant;
        private int numero;
        private static int compteur = 0;
        public Operation(decimal m)
        {
            Montant = m;
            numero = ++compteur;
        }

        public decimal Montant { get => montant; set => montant = value; }
    }
}
