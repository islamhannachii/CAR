using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RemotingInterfaces
{
    public interface IRemoteOperation
    {
        double Division(double a, double b);
        double Multiplication(double a, double b);
        double Soustraction(double a, double b);
        double Addition(double a, double b);
        double Racine(double valeur);
        double Pourcentage(double valeur);
        double Fraction(double valeur);
        double Inverse(double valeur);
    }
}