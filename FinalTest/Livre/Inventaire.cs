using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livre
{
    public class Inventaire
    {
        public void afficherCatalogueLivre(string path,IRep ir)
        {
            ir.afficherCatalogueLivre(path);
        }
    }
}
