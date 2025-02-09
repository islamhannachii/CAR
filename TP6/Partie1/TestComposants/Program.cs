using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComposantCalcul;
using CalculArithmetic;
using CalculScientific;
namespace TestComposants
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cc = new Calcul(); //______________________________________________________________________________// 
            Console.WriteLine("La somme est : " + cc.CalculerArithmetic(6, 2, "+",
            new ArithmeticOperation()));
            Console.WriteLine("La soustraction est : " + cc.CalculerArithmetic(6, 2, "-",
            new ArithmeticOperation()));
            Console.WriteLine("La multiplication est : " + cc.CalculerArithmetic(6, 2, "*",
            new ArithmeticOperation()));
            Console.WriteLine("La division est : " + cc.CalculerArithmetic(6, 2, "/",
            new ArithmeticOperation()));
            Console.WriteLine(); Console.WriteLine();
            //______________________________________________________________________________// 
            Console.WriteLine("La raine est : " + cc.CalculerScientific(4, 0, "sqrt",
            new ScientificOperation()));
            Console.WriteLine("La puissance est : " + cc.CalculerScientific(4, 2, "pow",
            new ScientificOperation()));
            Console.WriteLine("La pourcentage est : " + cc.CalculerScientific(2, 0, "%",
            new ScientificOperation()));
            Console.WriteLine("La fraction est : " + cc.CalculerScientific(2, 0, "frac",
            new ScientificOperation()));
            Console.WriteLine(); Console.WriteLine();
            //______________________________________________________________________________// 
            Console.ReadKey();
        }
    }
}