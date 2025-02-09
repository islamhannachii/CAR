using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Livre;

namespace Inventaire
{
    public class Rep : IRep
    {
        void IRep.afficherCatalogueLivre(string path)
        {
            XElement xml = XElement.Load(path);
           
            Console.WriteLine(xml);
          
        }
    }
}
