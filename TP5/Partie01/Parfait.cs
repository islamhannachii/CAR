using System;

namespace Partie01
{
    internal class Parfait
    {
        int sum_diviseur, diviseur;
        /* Méthode verifiant si num est un nombre parfait ou non */
        public Boolean Perfect(int num)
        {
            sum_diviseur = 0;
            for (diviseur = 1; diviseur <= num / 2; diviseur++)
                if (num % diviseur == 0)
                    sum_diviseur += diviseur;
            return (sum_diviseur == num);
        }
    }
}
