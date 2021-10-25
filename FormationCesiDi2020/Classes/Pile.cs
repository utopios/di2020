using System;
namespace FormationCesiDi2020.Classes
{
    public class Pile<T>
    {
        private T[] elements;
        private int compteur;

        public Pile(int taille)
        {
            elements = new T[taille];
            compteur = 0;
        }

        public void Empiler(T element)
        {
            if(compteur < elements.Length - 1)
            {
                //elements[compteur] = element;
                //compteur++;
                elements[compteur++] = element;
            }
        }

        public void Depiler()
        {
            if(elements.Length > 0)
            {
                elements[--compteur] = default(T);
            }
        }

        public T GetElement(int place)
        {
            if(compteur > place && place >=0)
            {
                return elements[place];
            }
            return default(T);
        }
    }
}
