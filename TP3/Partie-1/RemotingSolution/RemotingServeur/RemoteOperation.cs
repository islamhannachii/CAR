using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RemotingServeur
{
    public class RemoteOperation : MarshalByRefObject,
    RemotingInterfaces.IRemoteOperation
    {
        private double nombre = 0;
        /*-------------------------------------------------------------------*/
        // Indique que l'objet aura une durée de vie illimitée
        public override object InitializeLifetimeService()
        {
            return null;
        }
        /*-------------------------------------------------------------------*/
        // Définition de la Division
        public double Division(double a, double b)
        {
            Console.WriteLine("Appel client de la méthode Division : a=" + a + " b=" + b);
            if (b != 0) return a / b;
            else return -1;
        }
        /*-------------------------------------------------------------------*/
        // Définition de la Multiplication
        public double Multiplication(double a, double b)
        {
            Console.WriteLine("Appel client de la méthode Multiplication : a=" + a + " b=" +
            b);
            return a * b;
        }
        /*-------------------------------------------------------------------*/
        // Définition de la Soustraction
        public double Soustraction(double a, double b)
        {
            Console.WriteLine("Appel client de la méthode Soustraction : a=" + a + " b=" + b);
            return a - b;
        }
        /*-------------------------------------------------------------------*/
        // Définition de l’Addition
        public double Addition(double a, double b)
        {
            Console.WriteLine("Appel client de la méthode Addition : a=" + a + " b=" + b);
            return a + b;
        }
        /*-------------------------------------------------------------------*/
        // Définition de la Racine
        public double Racine(double valeur)
        {
            Console.WriteLine("Appel client de la méthode Racine : valeur=" + valeur);
            return Math.Sqrt(valeur);
        }
        /*-------------------------------------------------------------------*/
        // Définition de la Pourcentage
        public double Pourcentage(double valeur)
        {
            Console.WriteLine("Appel client de la méthode Pourcentage : valeur=" + valeur);
            return valeur / 100;
        }
        /*-------------------------------------------------------------------*/
        // Définition de la Fraction
        public double Fraction(double valeur)
        {
            Console.WriteLine("Appel client de la méthode Fraction : valeur=" + valeur);
            if (valeur != 0) return 1 / valeur;
            else return -1;
        }

        public double Inverse(double valeur)
        {
            Console.WriteLine("Appel client de la méthode Inverse : valeur=" + valeur);
            return valeur * -1;


            /*-------------------------------------------------------------------*/
        }
    }
}
