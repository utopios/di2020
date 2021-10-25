using System;
namespace CompteBancaire.Classes
{
    public class ComptePayant : Compte
    {
        private decimal coutOperation;
        public ComptePayant() : base()
        {
        }

        public ComptePayant(decimal s, decimal cout = 2) : base(s)
        {
            coutOperation = cout;
        }

        public override bool Depot(Operation o)
        {
            if(o.Montant > coutOperation)
            {
                return base.Depot(o) && base.Retrait(new Operation(coutOperation * -1));
            }
            return false;
        }

        public override bool Retrait(Operation o)
        {
            if(Solde > (o.Montant*-1)+ coutOperation)
            {
                return base.Retrait(o) && base.Retrait(new Operation(coutOperation * -1));
            }
            return false;
        }
    }
}
