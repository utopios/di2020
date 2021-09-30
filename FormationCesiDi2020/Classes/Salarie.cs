using System;
namespace FormationCesiDi2020.Classes
{
    public class Salarie
    {
        private string nomComplet;
        private string matricule;
        private string categorie;
        private string service;
        private decimal salaire;
        private static int compteur = 0;
        private static decimal totalSalaire = 0;


        

        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public decimal Salaire { get => salaire; set => salaire = value; }

        public static decimal TotalSalaire { get => totalSalaire; }


        public static int Compteur { get => compteur; }


        public Salarie(string nomComplet, string matricule, string categorie, string service, decimal salaire)
        {
            NomComplet = nomComplet;
            Matricule = matricule;
            Categorie = categorie;
            Service = service;
            Salaire = salaire;
            totalSalaire += salaire;
            compteur++;
        }

        public void AfficherSalaire()
        {
            Console.WriteLine($"Nom : {NomComplet}, Salaire : {Salaire} euros");
        }

        
    }
}
