using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ecrivain;
namespace Livre 
{
    public class Livre : IArchive
    {
        XElement catalogues;
        public void createXmlXelement()
        {
            catalogues = new XElement("catalogues");
            Console.WriteLine(); Console.WriteLine();
        }

        public void ajouterCatalogue(XElement element, string path)
        {
            catalogues.Add(element);
            catalogues.Save(path);
        }

        public void afficherCatalogues(string path)
        {
            XElement contactsFromFile = XElement.Load(@"" + path + "");
            Console.WriteLine(contactsFromFile);
        }

        
    }
}
