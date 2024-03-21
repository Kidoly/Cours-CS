using LesBasesDuCs;
using System.Collections.Generic;
using System.Linq;

namespace LesBasesDuCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pour ranger son code, il y a les regions
            #region Un bloc de code que je veux ranger
            //code
            //...
            #endregion

            #region déclaration de variables
            //en 2 fois : déclaration puis affectation
            int age;
            age = 25;

            //en 1 fois : déclaration et affectation
            int taille = 180;

            //var : le type est déduit par le compilateur
            var nom = "Dupont";
            #endregion

            #region opérateurs
            //opérateurs arithmétiques
            int a = 5;
            int b = 10;
            int c = a + b;
            //opérateurs de comparaison
            bool estEgal = a == b; //estEgal = false
            //opérateurs logiques
            bool estVrai = true;
            bool estFaux = false;
            bool resultat = estVrai && estFaux; //resultat = false
            #endregion

            #region tableaux
            //tableau de 5 entiers
            int[] tab = new int[5];
            tab[0] = 1;
            tab[1] = 2;
            tab[2] = 3;
            tab[3] = 4;
            tab[4] = 5;

            //version raccourcie
            int[] tab2 = { 1, 2, 3, 4, 5, 6 };

            //tableau à 2 dimensions
            int[,] tab3 = new int[2, 3];
            tab3[0, 0] = 1;
            tab3[0, 1] = 2;
            tab3[0, 2] = 3;
            tab3[1, 0] = 4;
            tab3[1, 1] = 5;
            tab3[1, 2] = 6;
            #endregion

            #region if et switch
            //if
            if (age < 18)
            {
                //code si vrai
            }
            else if (age >= 18 && age < 25)
            {
                //code si vrai
            }
            else
            {
                //code si faux
            }

            //switch
            switch (age)
            {
                case 18:
                    //code si age = 18
                    break;
                case 25:
                    //code si age = 25
                    break;
                default:
                    //code si age différent de 18 et 25
                    break;
            }

            JoursDeLaSemaine débutDeLaSemaine = JoursDeLaSemaine.Lundi;
            switch (débutDeLaSemaine)
            {
                case JoursDeLaSemaine.Lundi:
                    //code si débutDeLaSemaine = Lundi
                    break;
                case JoursDeLaSemaine.Mardi:
                    //code si débutDeLaSemaine = Mardi
                    break;
                case JoursDeLaSemaine.Mercredi:
                    //code si débutDeLaSemaine = Mercredi
                    break;
                case JoursDeLaSemaine.Jeudi:
                    //code si débutDeLaSemaine = Jeudi
                    break;
                case JoursDeLaSemaine.Vendredi:
                    //code si débutDeLaSemaine = Vendredi
                    break;
                case JoursDeLaSemaine.Samedi:
                    //code si débutDeLaSemaine = Samedi
                    break;
                case JoursDeLaSemaine.Dimanche:
                    //code si débutDeLaSemaine = Dimanche
                    break;
            }

            #endregion

            #region boucles
            //boucle for
            for (int i = 0; i < 10; i++)
            {
                //code
            }

            //boucle while
            int j = 0;
            while (j < 10)
            {
                //code
                j++;
            }

            //boucle do while
            int k = 0;
            do
            {
                //code
                k++;
            } while (k < 10);

            //boucle foreach
            int[] tab4 = { 1, 2, 3, 4, 5, 6 };
            foreach (int valeur in tab4)
            {
                //code
            }
            #endregion

            #region génériques
            var liste = new List<int>(); //on choisit le type de la liste
            liste.Add(1);

            #endregion

            #region types anonymes
            //on crée un type anonyme
            //utile pour stocker plusieurs valeurs
            //mais du coup pas de typage fort
            var personne = new { Nom = "Dupont", Age = "25" };
            #endregion

            #region génériques
            var liste11 = new List<int>();
            liste.Add(1);

            #endregion

            #region méthode d'extension
            //on ajoute une méthode à un type existant
            var chaine = "Bonjour";
            chaine= chaine.MettreEnMajusculeUneLettreSurDeux();
            #endregion

            #region LINQ
            var listeEntier= new List<int> { 1, -2, 3, -4, 5, -6 };

            //on veut les entiers positifs
            //var listePositive = new List<int>();
            //foreach (var entier in listeEntier)
            //{
            //    if (entier > 0)
            //    {
            //        listePositive.Add(entier);
            //    }
            //}

            var listePositive = listeEntier.Where(x => x > 0).ToList();

            var listeEntier2 = new List<int> { 8, 2, 5, 4, 3, 6 };

            //les éléments communs des 2 listes
            var listeCommune = listeEntier.Intersect(listeEntier2).ToList();

            #endregion


        }
    }
}
