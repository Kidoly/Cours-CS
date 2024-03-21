using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesBasesDuCs
{
    internal static class Extensions
    {
        public static string MettreEnMajusculeUneLettreSurDeux(this string s)
        {
            var resultat = new StringBuilder(s);
            for (int i = 0; i < s.Length; i += 2)
            {
                resultat[i] = char.ToUpper(s[i]);
            }
            return resultat.ToString();
        }
    }
}