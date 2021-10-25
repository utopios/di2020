using System;
namespace FormationCesiDi2020.Classes
{
    public class Calculatrice
    {
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
    }
}
