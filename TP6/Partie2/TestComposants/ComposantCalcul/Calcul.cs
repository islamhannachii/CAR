using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposantCalcul
{
    public class Calcul
    {
        public int CalculerArithmetic(int a, int b, string signe, IArithmetic Ia, IHistory Ih)
        {
            int resultat = 0;
            switch (signe)
            {
                case "+": resultat = Ia.Sommer(a, b); break;
                case "-": resultat = Ia.Soustraire(a, b); break;
                case "*": resultat = Ia.Multiplier(a, b); break;
                case "/": resultat = Ia.Diviser(a, b); break;
            }

            if (Ih != null)
            {
                Ih.SauvegarderOperation($"{a} {signe} {b}", resultat.ToString());
            }

            return resultat;
        }

        public double CalculerScientific(double a, double b, string signe, IScientific Is, IHistory Ih)
        {
            double resultat = 0;
            string operation = "";

            switch (signe)
            {
                case "sqrt":
                    resultat = Is.Racine(a);
                    operation = $"√{a}";
                    break;
                case "pow":
                    resultat = Is.Puissance(a, b);
                    operation = $"{a}^{b}";
                    break;
                case "%":
                    resultat = Is.Pourcentage(a);
                    operation = $"{a}%";
                    break;
                case "frac":
                    resultat = Is.Fraction(a);
                    operation = $"1/{a}";
                    break;
            }

            if (Ih != null)
            {
                Ih.SauvegarderOperation(operation, resultat.ToString());
            }

            return resultat;
        }
    }
}
