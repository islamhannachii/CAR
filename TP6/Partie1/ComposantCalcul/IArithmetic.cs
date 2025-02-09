using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ComposantCalcul
{
    public interface IArithmetic
    {
        int Sommer(int a, int b);
        int Soustraire(int a, int b);
        int Multiplier(int a, int b);
        int Diviser(int a, int b);
    }
}