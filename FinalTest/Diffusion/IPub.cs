using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Diffusion
{
    public interface IPub
    {
        void insererEcrivain(Ecrivain e);
        void insererLivre(Livre l);

    }
}
