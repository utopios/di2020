using System;
namespace FormationCesiDi2020.Classes
{
    public class Maison<T>
    {

        private T element;

        public Maison()
        {
        }

        public T Element { get => element; set => element = value; }

        public void AjouterElement(T e)
        {
            Element = e;
        }
    }
}
