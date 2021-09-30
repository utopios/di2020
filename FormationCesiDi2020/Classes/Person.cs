using System;
namespace FormationCesiDi2020.Classes
{
    public class Person
    {
        //Attributs
        //Niveau d'accessibilité, public, private, protected
        private string firstName;

        private string lastName;

        private int age;


        //Méthode

        public void Afficher()
        {
            Console.WriteLine(FirstName + " " + LastName +" "+ Age);
        }

        public void Afficher(string message)
        {
            //Console.WriteLine($"{message}, {FirstName}, {LastName}");
            Console.Write($"{message} ");
            Afficher();

        }

        //public string GetFirstName()
        //{
        //    //logique métier
        //    return firstName;
        //}
        //public void SetFirstName(string firstName)
        //{
        //    //Logique métier
        //    this.firstName = firstName;
        //}

        //Pour remplacer les méthodes getter et setter, le c# utilise la notion de propriété.

        public string LastName
        {
            get
            {
                //Logique métier
                return lastName;
            }
            set
            {
                //Logique métier
                lastName = value;
            }
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public int Age { get => age; set => age = value; }

        //Constructeur

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            Age = age;
        }


        //Destructeur
        //~Person()
        //{
        //    //logique à executer quand le gc supprime l'objet de la mémoire.
        //}
    }
}
