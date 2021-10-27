using System;
namespace coursWeb.Models
{
    public class Person
    {
        private string firstName;
        private string lastName;
        public Person()
        {
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
