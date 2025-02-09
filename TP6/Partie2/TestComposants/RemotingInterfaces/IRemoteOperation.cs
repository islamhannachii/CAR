using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingInterfaces
{
    public interface IRemoteOperation
    {
        //arithmetic
        int Sommer(int a, int b);
        int Soustraire(int a, int b);
        int Multiplier(int a, int b);
        int Diviser(int a, int b);

        //scientific
        double Racine(double a);
        double Puissance(double a, double b);
        double Pourcentage(double a);
        double Fraction(double a);

        void SauvegarderOperation(string operation, string resultat);
        List<string> AfficherHistorique();

    }
}
