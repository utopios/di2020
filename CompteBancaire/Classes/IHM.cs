using System;
namespace CompteBancaire.Classes
{
    public class IHM
    {

        Banque banque;
        public IHM()
        {
            banque = new Banque();
        }


        void MenuPrinpal()
        {

        }
        void MenuCreationCompte()
        {

        }

        Compte ActionRechercherCompte()
        {
            Console.WriteLine("Merci de saisir le numero du compte : ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Compte compte = banque.RechercherCompte(numero);
            return compte;
        }

        void ActionEffectuerDepot()
        {
            Compte compte = ActionRechercherCompte();
            if(compte != null)
            {
                Console.WriteLine("Merci de saisir le montant de depot : ");
                decimal montant = Convert.ToDecimal(Console.ReadLine());
                if(compte.Depot(new Operation(montant)))
                {
                    Console.WriteLine("Depot effecuté");
                }
                else
                {
                    Console.WriteLine("Erreur depot");
                }
            }
        }

        void ActionEffectuerRetrait()
        {

        }

    }
}
