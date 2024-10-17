using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01;

namespace TP01
{

    public struct Chiffre 
    {
        public Categorie categorieProduit { get; set; }
        public double chiffre { get; set; }
    }



    internal class Supperette
    {
        private string nom;
        private string adresse;
        private List<Produit> produits;

        public Supperette()
        {
            adresse = "";
            nom = "";
            produits = null;
        }
        public Supperette(string adresse, string nom, List<Produit> produits)
        {
            this.adresse = adresse;
            this.nom = nom;
            this.produits = produits;
        }

        public string Adresse { get => adresse; set => adresse = value; }
        public string Nom { get => nom; set => nom = value; }
        internal List<Produit> Produits { get => produits; set => produits = value; }

        public Produit chercherProduit(string designation)
        {
            return produits.Find(produit => produit.Designation == designation);
        }

        public void ajouterProduit(Produit unProduit)
        {
            produits.Add(unProduit);
        }

        public void supprimerProduit(int codeBarre)
        {
            produits.Remove(produits.Find(produit => produit.CodeBarre == codeBarre));
        }

        public void modifierProduit(int codeBarre, string designation, int quantité, DateTime expire, Categorie categorieProduit, double prix)
        {
            int i = produits.FindIndex(produit => produit.CodeBarre == codeBarre);
            produits[i].Designation = designation;
            produits[i].Quantite = quantité;
            produits[i].Expire = expire;
            produits[i].CategorieProduit = categorieProduit;
            produits[i].Prix = prix;
        }

        public int nbProduit()
        {
            return produits.Count;
        }


        public List<Chiffre> calculerChiffreAffaire()
        {
            List<Chiffre> chiffreAffaire = new List<Chiffre> ();

            foreach (Categorie categorie in Enum.GetValues(typeof(Categorie)))
            {
                double s = 0;
                if (categorie != Categorie.None)
                {
                    produits.FindAll(produit => produit.CategorieProduit == categorie).ForEach(produit => s += produit.Prix);
                    Chiffre c1 = new Chiffre();
                    c1.chiffre = s;
                    c1.categorieProduit= categorie;

                    chiffreAffaire.Add(c1);
                }
            }
            return chiffreAffaire;
        }

        public void afficher(List<Chiffre> liste)
        {
            foreach (Chiffre chiffre in liste)
            {
                Console.WriteLine("Categorie de " + chiffre.categorieProduit + " : " + chiffre.chiffre);
            }
        }
        public List<Produit> stocker()
        {
            return produits.FindAll(produit => produit.Prix > 5000);
        }

        public List<Produit> vendre()
        {
            return produits.FindAll(produit => produit.CategorieProduit == Categorie.Cosmetique && produit.Prix < 1000 && produit.Expire == new DateTime(2021, 1, 1));
        }
    }
}
