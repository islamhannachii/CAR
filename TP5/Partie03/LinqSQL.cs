using System;
using System.Data.Linq;
using System.Linq;
namespace Partie03
{
    internal class LinqSQL
    {

        Table<Compte> comptes;
        DataContext db;
        /*_____________________________________*/
        /* 1. Sélection des données d'une table */
        public void init()
        {
            try
            {
                db = new
            DataContext(@"PARTIE03\DATABASE1.MDF");
                comptes = db.GetTable<Compte>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        /*_____________________________________*/
        /* 2. Afficher les données d'une table */
        public void afficher()
        {
            var all = from c in comptes select c;
            if (all != null)
            {
                foreach (Compte c in all)
                {
                    Console.WriteLine(c.Id + " " + c.Solde);
                }
            }
        }
        /*______________________________________________*/
        /* 3. Insertion de deux éléments dans la table */
        public void inserer()
        {
            init();
            try
            {
                Compte nco = new Compte { Id = 1, Solde = 27 };
                comptes.InsertOnSubmit(nco);
                nco = new Compte { Id = 2, Solde = 29 };
                comptes.InsertOnSubmit(nco);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        /*___________________________________________*/
        /* 4. Modification d’un élément de la table */
        public void modifier()
        {
            var all = from c in comptes where c.Id == 1 select c;
            foreach (Compte c in all)
            {
                c.Solde = 24;
            }
            db.SubmitChanges();
        }
        /*__________________________________________*/
        /* 5. Suppression d’un élément de la table */
        public void supprimer()
        {
            var all = from c in comptes where c.Id == 2 select c;
            foreach (Compte c in all)
            {
                comptes.DeleteOnSubmit(c);
                db.SubmitChanges();
            }
        }
    }
}
