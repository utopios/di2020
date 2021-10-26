using System;
namespace FormationCesiDi2020.Classes
{
    public class Voiture
    {
        private string model;
        private decimal prix;
        public event Action<string,decimal> Promotion;

        public Voiture()
        {
        }

        public string Model { get => model; set => model = value; }
        public decimal Prix { get => prix; set => prix = value; }

        public void Reduction(decimal reduction)
        {
            Prix -= reduction;
            //Action envoie mail, envoie notification...
            //Démarrer l'event
            if(Promotion != null)
            {
                Promotion(Model, Prix);
            }
        }
    }
}
