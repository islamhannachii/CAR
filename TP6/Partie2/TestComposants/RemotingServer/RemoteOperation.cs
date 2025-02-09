
using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using ComposantCalcul;
using CalculArithmetic;
using CalculScientific;
using Historic;

namespace RemotingServer
{
    public class RemoteOperation : MarshalByRefObject, RemotingInterfaces.IRemoteOperation
    {
        public int Sommer(int a, int b)
        {
            var cc = new Calcul();
             return cc.CalculerArithmetic(a, b, "+", new ArithmeticOperation(), new HistoriqueOperation());
            throw new NotImplementedException();
        }

        public int Soustraire(int a, int b)
        {
            var cc = new Calcul();
            return cc.CalculerArithmetic(a, b, "-", new ArithmeticOperation(), new HistoriqueOperation());
            throw new NotImplementedException();
        }

        public int Multiplier(int a, int b)
        {
            var cc = new Calcul();
            return cc.CalculerArithmetic(a, b, "*", new ArithmeticOperation(), new HistoriqueOperation());
            throw new NotImplementedException();
        }

        public int Diviser(int a, int b)
        {
            var cc = new Calcul();
            return cc.CalculerArithmetic(a, b, "/", new ArithmeticOperation(), new HistoriqueOperation());
            throw new NotImplementedException();
        }

        public double Racine(double a)
        {
            var cc = new Calcul();
            return cc.CalculerScientific(a, a, "sqrt", new ScientificOperation(), new HistoriqueOperation());
            throw new NotImplementedException();
        }

        public double Puissance(double a, double b)
        {
            var cc = new Calcul();
            return cc.CalculerScientific(a, b, "pow", new ScientificOperation(), new HistoriqueOperation());
            throw new NotImplementedException();
        }

        public double Pourcentage(double a)
        {
            var cc = new Calcul();
            return cc.CalculerScientific(a, a, "%", new ScientificOperation(), new HistoriqueOperation());
            throw new NotImplementedException();
        }

        public double Fraction(double a)
        {
            var cc = new Calcul();
            return cc.CalculerScientific(a, a, "frac", new ScientificOperation(), new HistoriqueOperation());
            throw new NotImplementedException();
        }

        public void SauvegarderOperation(string operation, string resultat)
        {
            throw new NotImplementedException();
        }

        public List<string> AfficherHistorique()
        {
            try
            {
                var cc = new HistoriqueOperation();
                return cc.AfficherHistorique();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
