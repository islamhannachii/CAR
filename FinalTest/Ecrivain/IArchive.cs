using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ecrivain
{
    public interface IArchive
    {
        void ajouterCatalogue(XElement element, string path);
        void afficherCatalogues(string path);
    }
}
