using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using TP01;

namespace TP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produit p1 = new Produit(1, "Gateau 1", 300, DateTime.Today, Categorie.Alimentaire, 100);
            Produit p2 = new Produit(2, "Gateau 2", 300, DateTime.Today, Categorie.Alimentaire, 200);
            Produit p3 = new Produit(3, "Gateau 3", 300, DateTime.Today, Categorie.Alimentaire, 300);
            Produit p4 = new Produit(4, "Gateau 4", 300, DateTime.Today, Categorie.Alimentaire, 400);
            Produit p5 = new Produit(5, "Gateau 6", 300, DateTime.Today, Categorie.Alimentaire, 500);
            Produit p6 = new Produit(6, "Gateau 7", 300, DateTime.Today, Categorie.Alimentaire, 6000);
            //DateTime date = new DateTime(2021, 1, 1);
            Produit p7 = new Produit(6, "Gateau 8", 300, new DateTime(2021, 1, 1), Categorie.Cosmetique, 500);

            List<Produit> produits = new List<Produit>
            {
                p1,
                p2,
                p3,
                p4,
                p5,
                p6,
                p7
            };

            foreach (Produit produit in produits)
            {
                produit.afficher();
            }
            Supperette s1 = new Supperette("alger", "Elhannaa",produits);
            

            p1 = s1.chercherProduit("Gateau xx");
            
            if(p1 != null) { p1.afficher(); } else { Console.WriteLine("Ce produit n'existe pas"); }

            Console.WriteLine("Calculer le chiffre d'affaire");
            List<Chiffre> chiffres  = s1.calculerChiffreAffaire();

            Console.WriteLine("Affichage de chiffre d'affaire:");

            s1.afficher(chiffres);


            List<Produit> stock =  s1.stocker();
            Console.WriteLine("\n Liste de stock:\n");
            foreach (Produit produit in stock)
            {
                produit.afficher();
            }

            Console.WriteLine("\n Produit a vendre:\n");

            List<Produit> vente =  s1.vendre();
            foreach (Produit produit in vente)
            {
                produit.afficher();
            }


        }
    }
}
