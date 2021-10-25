using System;
namespace FormationCesiDi2020.Classes
{
    public class Calculatrice
    {
        //Un delegate est un type qui permet de stocker des méthodes.
        //public delegate int Calcule(int a, int b);

        //Pour eviter de créer un delegate à chaque fois, on peut utiliser les delegates génériques Action, Func
        public Calculatrice()
        {
        }

        public void Addition(int a, int b)
        {
            a *= 2;
            Console.WriteLine(a + b);
        }

        public void AdditionParReference(ref int a, ref int b)
        {
            a *= 2;
            Console.WriteLine(a + b);
        }

        public void AdditionParReferenceOut(out int a, ref int b)
        {
            a = 2;
            Console.WriteLine(a + b);
        }

        public void MethodeCalcule(int a, int b, Func<int,int,int> methode)
        {
            Console.WriteLine(methode(a, b)); 
        }
    }
}
