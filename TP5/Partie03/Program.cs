using System;

namespace Partie03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqSQL lo = new LinqSQL();
            lo.init();
            Console.WriteLine("\n insertion");
            //lo.inserer();
            lo.afficher();
            Console.WriteLine("\n modification");
            lo.modifier();
            lo.afficher();
            Console.WriteLine("\n suppression");
            lo.supprimer();
            lo.afficher();
            Console.ReadKey();
        }
    }
}
