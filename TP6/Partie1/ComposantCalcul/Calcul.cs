using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ComposantCalcul
{
    public class Calcul
    {
        //________________________________________________________________// 
        public int CalculerArithmetic(int a, int b, string signe, IArithmetic Ia)
        {
            switch (signe)
            {
                case "+": { return (Ia.Sommer(a, b)); }
                case "-": { return (Ia.Soustraire(a, b)); }
                case "*": { return (Ia.Multiplier(a, b)); }
                case "/": { return (Ia.Diviser(a, b)); }
                default: { return 0; }
            }
        }
        //________________________________________________________________// 
        public double CalculerScientific(double a, double b, string signe,
        IScientific Is)
        {
            switch (signe)
            {
                case "sqrt": { return (Is.Racine(a)); }
                case "pow": { return (Is.Puissance(a, b)); }
                case "%": { return (Is.Pourcentage(a)); }
                case "frac": { return (Is.Fraction(a)); }
                default: { return 0; }
            }
        }
        //________________________________________________________________// 
    }
}