using System;

namespace Partie01
{
    class Livre
    {
        private String titre;
        private String auteur;
        private int nbExemplaire;
        private int annee;
        private double prix;

        public String Titre
        {
            set { titre = value; }
            get { return titre; }
        }
        public String Auteur
        {
            set { auteur = value; }
            get { return auteur; }
        }
        public int NbExemplaire
        {
            set { nbExemplaire = value; }
            get { return nbExemplaire; }
        }
        public int Annee
        {
            set { annee = value; }
            get { return annee; }
        }
        public double Prix
        {
            set { prix = value; }
            get { return prix; }
        }

    }
};
