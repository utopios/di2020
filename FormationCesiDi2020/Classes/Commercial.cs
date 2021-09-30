using System;
namespace FormationCesiDi2020.Classes
{
    public class Commercial : Salarie
    {
        private decimal chiffreAffaire;
        private decimal commission;
        public decimal ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }
        public decimal Commission { get => commission; set => commission = value; }

        public Commercial(): base()
        {

        }
        public Commercial(string nomComplet, string matricule, string categorie, string service, decimal salaire, decimal chiffreAffaire, decimal commission) : base(nomComplet, matricule, categorie, service, salaire)
        {
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }

        public override decimal CalculerSalaire()
        {
            return base.CalculerSalaire() + (chiffreAffaire * Commission / 100);
        }

        public override void AfficherSalaire()
        {
            Console.WriteLine("---Commercial----");
            base.AfficherSalaire();
        }
    }
}
