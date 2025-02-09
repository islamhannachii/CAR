using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ecrivain
{
    public class Livres
    {
        public void ajouterCatalogue(XElement element, string path, IArchive ia)
        {
            ia.ajouterCatalogue(element, path); 
        }
        public void afficherCatalogues(string path, IArchive ia)
        {
            ia.afficherCatalogues(path);
        }
    }
}
