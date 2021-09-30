using System;
namespace FormationCesiDi2020.Classes
{
    public class IHM
    {
        public void Start()
        {
            Salarie s1 = new Salarie("toto", "123", "c1", "s1", 4000);
            Salarie s2 = new Salarie("tata", "1234", "c2", "s1", 3000);
            Salarie s3 = new Salarie("titi", "2234", "c2", "s1", 2000);

            s1.AfficherSalaire();
            s2.AfficherSalaire();
            s3.AfficherSalaire();

            Console.WriteLine($"Total salaire : {Salarie.TotalSalaire}, nombre de salariés {Salarie.Compteur}");
        }
    }
}
