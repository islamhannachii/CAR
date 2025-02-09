using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace RemotingInterfaces
{
    public interface IRemoteOperation
    {
        void insererE(string nom, string prenom, int matricule);
        void insererL(int code, string titre, string langue, int annee, int matricule);
        void ajouterCatalogue(string element, string path);
    }
}
