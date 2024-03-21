using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEtGeneric
{
    internal class Chaton
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Couleur { get; set; }
        
        public bool Miauler()
        {
            Console.WriteLine("Miaou");
            return true;
        }
    }
}
