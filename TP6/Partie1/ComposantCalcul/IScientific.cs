using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ComposantCalcul { 
    public interface IScientific 
    {
        double Racine(double a); double Puissance(double a, double b);
        double Pourcentage(double a); double Fraction(double a);
    }
}