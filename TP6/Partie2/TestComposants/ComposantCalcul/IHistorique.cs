using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposantCalcul
{
    public interface IHistory
    {
        void SauvegarderOperation(string operation, string resultat);
        System.Collections.Generic.List<string> AfficherHistorique();
    }

}
