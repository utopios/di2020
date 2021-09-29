using System;

namespace FormationCesiDi2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("hello from ihab");
            //Déclaration de variables
            //Type primitive
            //int age = 34;
            //age = 33;
            //bool test = true;
            //string nom = "ihab";
            ////string chaine = "Bonjour "+ nom;
            //string chaine = $"Bonjour {nom}";

            //Instruction de la console.
            //Ecriture
            //Console.WriteLine(chaine);
            //Console.WriteLine(chaine.Length);
            //Console.Write("Totot");
            //Console.Write("Tata");

            //Lecture à partir d'une console
            //Console.Write("Merci de saisir un nombre : ");
            //string chaine = Console.ReadLine();
            //Console.WriteLine(chaine.GetType());

            //Readline récupère que des chaines de caractères.
            //On peut essayer de convertir une chaine de caracères à l'aide de la classe Convert
            //int nombre = Convert.ToInt32(chaine);
            //nombre += 30;
            //Console.WriteLine(nombre.GetType());
            //Strucutre conditionnelle et itérative
            //if else
            //int age = 33;
            //if (age >= 18)
            //    Console.WriteLine("Majeur");
            //else
            //{
            //    Console.WriteLine("Mineur");
            //}
            //switch
            //int mois = 1;
            //switch(mois)
            //{
            //    case 1:
            //        Console.WriteLine("Janvier");
            //        break;
            //    case 2:
            //        Console.WriteLine("Février");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mars");
            //        break;

            //    default:
            //        Console.WriteLine("Erreur");
            //        break;
            //}

            //Ternaire

            //int age = 33;
            //string result = (age >= 18) ? "majeur" : "mineur";

            //For

            //for(int i=1; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Desc");
            //for (int i = 10; i >= 0; i=i-2)
            //{
            //    Console.WriteLine(i);
            //}

            //while

            int age = 33;

            //while(age < 18)
            //{
            //    Console.WriteLine("Mineur");
            //    age++;
            //}

            //do while
            do
            {
                Console.WriteLine("Mineur");
                age++;
            } while (age < 18);
        }
    }
}
