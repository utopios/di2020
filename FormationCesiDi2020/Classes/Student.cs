using System;
namespace FormationCesiDi2020.Classes
{
    public sealed class Student : Person
    {
        private int level;

       

        public int Level { get => level; set => level = value; }

        public Student(string firstName, string lastName, int age, int level) : base(firstName, lastName, age)
        {
            Level = level;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Niveau {Level}");
        }

        public override string ToString()
        {
            return $"Nom complet {FirstName} {LastName}, Age {Age}";
        }

        public override void MethodeAbstract()
        {
            throw new NotImplementedException();
        }
    }
}
