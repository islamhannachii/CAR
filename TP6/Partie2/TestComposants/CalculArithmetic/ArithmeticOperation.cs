using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculArithmetic
{
    public class ArithmeticOperation: ComposantCalcul.IArithmetic
    {
        public int Sommer(int a, int b) { return (a + b); }
        public int Soustraire(int a, int b) { return (a - b); }
        public int Multiplier(int a, int b) { return (a * b); }
        public int Diviser(int a, int b) { return (a / b); }
    }
}
