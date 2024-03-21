using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEtGeneric
{
    internal class Liste<T> : IEnumerable<int>
    {
        //une liste d'éléments non typés
        private ArrayList elements;

        public int Count => elements.Count;
        //version non raccourcie
        //public int Count
        //{
        //    get
        //    {
        //        return elements.Count;
        //    }
        //}

        public T this[int index]
        {
            get
            {
                return (T)elements[index];
            }
        }

        public Liste()
        {
            elements = new ArrayList();
        }

        public void Ajouter(T element)
        {
            elements.Add(element);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in elements)
            {
                yield return (T)item;
            }   
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Trier(DelegateQuiCompareDeuxTrucs<T> test)
        {
            //faire un tri par inversion
            for (int i = 0; i < Count; i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (test(this[i], this[j]))
                    {
                        var temp = this[i];
                        elements[i] = elements[j];
                        elements[j] = temp;
                    }
                }
            }
        }
    }
}
