using System;
namespace FormationCesiDi2020.Classes
{
    public class IHMEmploye
    {
        Salarie[] salaries;
        int compteur;
        
        public IHMEmploye()
        {
            salaries = new Salarie[20];
            compteur = 0;
        }


        public void Start()
        {
            string choix;

            do
            {
                Menu();
                Console.Write("Merci de saisir votre choix : ");
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                        AjouterEmploye();
                        break;
                    case "2":
                        AfficherSalaire();
                        break;
                    case "3":
                        RechercherEmploye();
                        break;
                }
            } while (choix != "0");
        }

        private void Menu()
        {
            Console.WriteLine("1 -- Ajouter un employé");
            Console.WriteLine("2 -- Afficher les salaires des employés");
            Console.WriteLine("3 -- Rechercher un employé");
            Console.WriteLine("0 -- Quitter");
        }

        private void AjouterEmploye()
        {
            Salarie employe;
            Console.Write("Merci de saisir le nom complet : ");
            string nomComplet = Console.ReadLine();
            Console.Write("Merci de saisir le matricule : ");
            string matricule = Console.ReadLine();
            Console.Write("Merci de saisir la catégorie : ");
            string categorie = Console.ReadLine();
            Console.Write("Merci de saisir le service : ");
            string service = Console.ReadLine();
            Console.Write("Merci de saisir le salaire de base : ");
            decimal salaire = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Est ce que c'est un commercial (O/N) : ");
            string isCommercial = Console.ReadLine();
            if(isCommercial == "O")
            {
                Console.Write("Merci de saisir le chiffre d'affaire : ");
                decimal chiffreAffaire = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Merci de saisir la commission : ");
                decimal commission = Convert.ToDecimal(Console.ReadLine());
                employe = new Commercial(nomComplet, matricule, categorie, service, salaire, chiffreAffaire, commission);
            }
            else
            {
                employe = new Salarie(nomComplet, matricule, categorie, service, salaire);
            }
            if(compteur < salaries.Length - 1)
            {
                salaries[compteur++] = employe;
            }
            else
            {
                Console.WriteLine("On ne recrute plus");
            }
        }

        private void AfficherSalaire()
        {
            foreach(Salarie s in salaries)
            {
                if(s != null)
                    s.AfficherSalaire();
            }
        }
        private void RechercherEmploye()
        {
            Console.WriteLine("Merci de saisir le nom : ");
            string nom = Console.ReadLine();
            Salarie employe = null;
            foreach(Salarie s in salaries)
            {
                if(s.NomComplet == nom)
                {
                    employe = s;
                    break;
                }
            }
            if(employe != null)
            {
                employe.AfficherSalaire();
            }
            else
            {
                Console.WriteLine("Aucun employé avec ce nom : ");
            }
        }
    }
}
