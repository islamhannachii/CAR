using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01;

namespace TP01
{
    internal class Produit
    {
        private int codeBarre;
        private string designation;
        private int quantite;
        private DateTime expire;
        private Categorie categorieProduit;
        private double prix;

        public Produit()
        {
            codeBarre = 0;
            designation = "";
            quantite = 0;
            expire = DateTime.Now;
            categorieProduit = Categorie.None;
            prix = 0;
        }

        public Produit(int codeBarre, string designation, int quantite, DateTime expire, Categorie categorieProduit, double prix)
        {
            this.codeBarre = codeBarre;
            this.designation = designation;
            this.quantite = quantite;
            this.expire = expire;
            this.categorieProduit = categorieProduit;
            this.prix = prix;
        }

        public int CodeBarre
        {
            get { return this.codeBarre; }
            set { this.codeBarre = value; }
        }


        public string Designation
        {
            get { return this.designation; }
            set { this.designation = value; }
        }


        public int Quantite
        {
            get { return this.quantite; }
            set { this.quantite = value; }
        }


        public Categorie CategorieProduit
        {
            get { return this.categorieProduit; }
            set { this.categorieProduit = value; }
        }

        public DateTime Expire
        {
            get { return this.expire; }
            set { this.expire = value; }
        }

        public double Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public bool egalite(Produit unproduit)
        {
            return unproduit is Produit produit &&
                   prix == produit.prix;
        }

        public string toString()
        {
            return $"{codeBarre}, '{designation}', {quantite}, {expire}, {categorieProduit}, {prix} DA";
        }

        public void afficher()
        {
            Console.WriteLine(toString());
        }

    }
}
