using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ecrivain;
namespace Livre
{
    public class GestionDeLivre : IArchive
    {


         void IArchive.ajouterCatalogue(XElement element, string path)
        {
            XElement xElement = XElement.Load(path);
            xElement.Add(element);
            xElement.Save(path);
        }

         void IArchive.afficherCatalogues(string path)
        {
           XElement element = XElement.Load(path);  
            Console.WriteLine(element);
        }
    }
}
