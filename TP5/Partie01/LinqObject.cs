using System;
using System.Collections.Generic;
using System.Linq;

namespace Partie01
{
    internal class LinqObject
    {
        public void requeteTableau()
        {
            Console.WriteLine("1- Requête sur les Tableaux...");
            int[] tab = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> pairs =
            from number in tab
            where number % 2 == 0
            select number;
            Console.WriteLine("Liste des nombres pairs de 1 à 10");
            Console.WriteLine("_________________________________");
            foreach (int i in pairs) { Console.WriteLine(i); }
            Console.WriteLine("_________________________________");
            Console.WriteLine(); Console.WriteLine();
        }
        /*_______________________________________________________________*/
        /* 2. Exemple de requêtes sur un tableau avec appel de méthode */
        public void requeteTableauMethode()
        {
            Parfait p = new Parfait();
            int[] tab = new int[10000];

            for (int i = 1; i <= 10000; i++)
            { tab[i - 1] = i; }
            IEnumerable<int> parfait =
            from number in tab
                //where p.Perfect(number).Equals(true)
            where p.Perfect(number)
            select number;
            Console.WriteLine("Liste des nombres parfait de 1 à 10000");
            Console.WriteLine("______________________________________");
            foreach (int i in parfait) { Console.WriteLine("Nombre .... " + i); }
            Console.WriteLine("______________________________________");
            Console.WriteLine(); Console.WriteLine();
        }
        /*_______________________________________________________________*/
        /* 3. Exemple d'interrogation d'une collection d'objets */
        public void requeteCollection()
        {
            Console.WriteLine("2- Requête sur les Collections...");
            var livre = new List<Livre>() { new Livre { Titre = "Java", Auteur = "Deitel", NbExemplaire = 5, Annee = 2012, Prix=1700},
 new Livre { Titre = "Java", Auteur = "yyy", NbExemplaire
 = 4, Annee = 2012, Prix=1798.50 },
 new Livre { Titre = "C#", Auteur = "xxx", NbExemplaire
 = 2, Annee = 2010, Prix=1200.75 } };
            var books = from b in livre
                        where b.Titre.Equals("Java") && b.NbExemplaire > 4
                        select b;
            foreach (var book in books)
            {
                Console.WriteLine(book.Titre + " " + book.Auteur + " " +
                book.NbExemplaire + " " + book.Annee);
            }

            Console.WriteLine("______________________________________");
            Console.WriteLine(); Console.WriteLine();
        }
        /*_______________________________________________________________*/
        /* 4. Exemple de jointure sur une collection d'objets */
        public void jointureCollection()
        {
            Console.WriteLine("3- Jointure sur les Collections...");
            var livre = new List<Livre>() {
 new Livre { Titre = "Java", Auteur = "Deitel",
 NbExemplaire = 5, Annee = 2012 },
 new Livre { Titre = "Algèbre", Auteur = "yyy",NbExemplaire = 1, Annee = 2012 }};
            var ouvrages = new List<Ouvrage>() {
 new Ouvrage { Titre = "Java", Type = "Infomatique" },
 new Ouvrage { Titre = "Algèbre", Type = "Maths" } };
            var livres =
            from l in livre
            join o in ouvrages on l.Titre equals o.Titre
            where o.Type == "Maths"
            select l;
            Console.WriteLine("Liste des livres de Maths ");
            Console.WriteLine("__________________________");
            foreach (var liv in livres)
            {
                Console.WriteLine(liv.Titre + " " + liv.Auteur + " " + liv.Annee
                + " Maths");
            }
            Console.WriteLine("______________________________________");
            Console.WriteLine(); Console.WriteLine();
        }
        /*_______________________________________________________________*/
        /* 5. Exemple d'utilisation de l'opérateur OfType<T> sur */
        /* collections et tableaux */
        public void operateurOfType()
        {
            Console.WriteLine("4- Utilisation de l'opérateur OfType<T>...");
            object[] array = { 1, "Java", 'T', 1500.75, 5, true, 2012, "Informatique" };
            Console.WriteLine(" Liste des objets de type <int> ");
            var results = array.OfType<int>();
            foreach (int i in results) { Console.WriteLine(i); }
            Console.WriteLine();
            Console.WriteLine(" Liste des objets de type <String> ");
            var results1 = array.OfType<String>();
            foreach (String s in results1) { Console.WriteLine(s); }
            Console.WriteLine();
            Console.WriteLine(" Liste des objets de type <double> ");
            var results2 = array.OfType<double>();
            foreach (double d in results2) { Console.WriteLine(d); }
            Console.WriteLine();
            Console.WriteLine(" Liste des objets de type <Boolean> ");
            var results3 = array.OfType<Boolean>();
            foreach (Boolean b in results3) { Console.WriteLine(b); }
            Console.WriteLine();
            Console.WriteLine("Liste des objets de type <Char> ");
            var results4 = array.OfType<Char>();
            foreach (Char c in results4) { Console.WriteLine(c); }
            Console.WriteLine();
            Console.WriteLine("______________________________________");
            Console.WriteLine(); Console.WriteLine();
        }
        public void operateursAgregation()
        {
            Console.WriteLine("5- Utilisation de Min, Max, Sum et Average...");
            int[] IntegerValues = { 0, 2, 5, 6, 7 };
            int max = IntegerValues.Max();
            Console.WriteLine("Le maximum est: " + max);
            Console.WriteLine();
            int min = IntegerValues.Min();
            Console.WriteLine("Le minimum est: " + min);
            Console.WriteLine();
            int sum = IntegerValues.Sum();
            Console.WriteLine("La somme est: " + sum);
            Console.WriteLine();
            double average = IntegerValues.Average();
            Console.WriteLine("La moyenne est: " + average);
            Console.WriteLine();
            Console.WriteLine("______________________________________");
            Console.WriteLine(); Console.WriteLine();
        }
        public void operateursDivers()
        {
            Console.WriteLine("Utilisation de Where, Count, ToArray et ToList...");

            var valeur = new object[] { 1, "Java", 'T', 1500.75, 5, true, 2012, "Informatique" };

            var val = valeur.Where(v => v.ToString().Length >= 4);
            Console.WriteLine("Liste des items dont la longueur >= 4 :");
            foreach (object o in val)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine();

            int i = valeur.Count(v => v.ToString().Length >= 3);
            {
                Console.WriteLine("Nombre d'item dont la longueur >= 3 : " + i);
            }
            Console.WriteLine();
            object[] array = valeur.ToArray();
            List<object> list = array.ToList();
            Console.WriteLine("Les des items de la liste :");
            foreach (object l in list)
            {
                Console.WriteLine("Item... " + l.ToString());
            }
            Console.WriteLine("______________________________________");
            Console.WriteLine(); Console.WriteLine();
        }
    }
};
