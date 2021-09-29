using System;

namespace FormationCesiDi2020
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cours Base c#
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

            //int age = 33;

            ////while(age < 18)
            ////{
            ////    Console.WriteLine("Mineur");
            ////    age++;
            ////}

            ////do while
            //do
            //{
            //    Console.WriteLine("Mineur");
            //    age++;
            //} while (age < 18);
            #endregion

            #region exercice 1
            //decimal netImposable, reference, impot;
            //int nbAdule;
            //int nbEnfant;

            //Console.WriteLine("=====Calcule Impôt=======");
            //Console.Write("Merci de saisir votre net imposable : ");
            //netImposable = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Merci de saisir le nombre d'adultes : ");
            //nbAdule = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Merci de saisir le nombre d'enfants : ");
            //nbEnfant = Convert.ToInt32(Console.ReadLine());
            //decimal nbParts = nbAdule + (nbEnfant > 2 ? nbEnfant - 1 : (decimal)nbEnfant / 2);
            //reference = netImposable / nbParts;
            //switch(reference)
            //{
            //    case decimal net  when net >=158122 :
            //        impot = (netImposable * 0.45M) - 20405.78M * nbParts; 
            //        break;
            //    case decimal net when net < 158122 && net >= 73516:
            //        impot = (netImposable * 0.41M) - 14080.90M * nbParts;
            //        break;
            //    case decimal net when net < 73516 && net >= 25710:
            //        impot = (netImposable * 0.30M) - 5994.14M * nbParts;
            //        break;
            //    case decimal net when net < 25710 && net >= 10084:
            //        impot = (netImposable * 0.11M) - 1109.24M * nbParts;
            //        break;
            //    default:
            //        impot = 0;
            //        break;
            //}
            //Console.WriteLine($"Votre impot est de {impot}euros");
            #endregion

            #region exercice 2
            //Console.WriteLine("=====Calcule de moyenne=====");
            //double min = 0, max = 0, moyenne, total = 0, note;
            //int count = 5;
            //for(int i=1; i<= count; i++)
            //{
            //    Console.Write($"Merci de saisir la note N°{i} : ");
            //    note = Convert.ToDouble(Console.ReadLine());
            //    total += note;
            //    if(i ==1) {
            //        min = note;
            //        max = note;
            //    }
            //    else
            //    {
            //        if(note >= max)
            //        {
            //            max = note;
            //        }
            //        else if(note <= min)
            //        {
            //            min = note;
            //        }
            //    }
            //}
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"La note min est de {min}");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"La note max est de {max}");
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.WriteLine($"La note moyenne est de {total/count}");
            #endregion

            #region exercice 3
            //Console.WriteLine("=====Calcule de moyenne=====");
            //double min = 0, max = 0, moyenne, total = 0, note = 0;
            //int count = 0;
            //do
            //{
            //    Console.Write($"Merci de saisir la note N°{count+1} : ");
            //    note = Convert.ToDouble(Console.ReadLine());
            //    if(note == 999)
            //    {
            //        break;
            //    }
            //    else if(note < 0 || note > 20)
            //    {
            //        Console.WriteLine("Merci de saisir une note correct");
            //    }
            //    else
            //    {
            //        total += note;
            //        if (count == 1)
            //        {
            //            min = note;
            //            max = note;
            //        }
            //        else
            //        {
            //            if (note >= max)
            //            {
            //                max = note;
            //            }
            //            else if (note <= min)
            //            {
            //                min = note;
            //            }
            //        }
            //        count++;
            //    }

            //} while (note != 999);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"La note min est de {min}");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"La note max est de {max}");
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.WriteLine($"La note moyenne est de {total / count}");
            #endregion

            #region suite cours
            //Tableau
            //int[] tabEntiers = new int[4];

            //for(int i=0; i < tabEntiers.Length; i++)
            //{
            //    Console.Write($"Merci de saisir la valeur de la case N° {i} : ");
            //    tabEntiers[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(tabEntiers[i]);
            //}

            //string[] mots = new string[] { "test1", "test2", "test3"};
            //foreach(string m in mots)
            //{
            //    Console.WriteLine(m);
            //}

            //string chaine = "coucou";

            //Console.WriteLine(chaine[2]);

            //Pour générer un nombre aléatoire en c#
            Random r = new Random();
            int aleat = r.Next(100);
            Console.WriteLine(aleat);
            #endregion
        }
    }
}
