using System;

namespace Partie01
{
    internal class Ouvrage
    {
        private String titre;
        private String type;
        public String Titre
        {
            set { titre = value; }
            get { return titre; }
        }
        public String Type
        {
            set { type = value; }
            get { return type; }
        }

    }
}
