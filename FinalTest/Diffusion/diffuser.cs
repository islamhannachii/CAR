using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Diffusion
{
    public class diffuser
    {
        public void insererE(Ecrivain e1, IPub ip)
        {
            ip.insererEcrivain(e1);
        }
        public void insererL(Livre e1, IPub ip)
        {
            ip.insererLivre(e1);
        }
       
    }
}
