using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculScientific {
    public class ScientificOperation : ComposantCalcul.IScientific
    { public double Racine(double a) { return Math.Sqrt(a); }
        public double Puissance(double a, double b) { return Math.Pow(a, b); }
        public double Pourcentage(double a) { return (a / 100); } 
        public double Fraction(double a) { if (a != 0) return (1 / a); return 0; } } 
}