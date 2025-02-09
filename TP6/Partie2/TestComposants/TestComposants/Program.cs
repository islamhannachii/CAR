using CalculArithmetic;
using CalculScientific;
using ComposantCalcul;
using Historic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters;

namespace TestComposants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Configure security
                BinaryServerFormatterSinkProvider serverProvider = new BinaryServerFormatterSinkProvider();
                BinaryClientFormatterSinkProvider clientProvider = new BinaryClientFormatterSinkProvider();
                serverProvider.TypeFilterLevel = TypeFilterLevel.Full;

                // Create dictionary for channel properties
                IDictionary props = new Hashtable();
                props["port"] = 8000;

                // Register TCP channel with security configuration
                TcpChannel channel = new TcpChannel(props, clientProvider, serverProvider);
                ChannelServices.RegisterChannel(channel, false);

                // Register all services
                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(Calcul),
                    "CalculService",
                    WellKnownObjectMode.Singleton);

                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(ArithmeticOperation),
                    "ArithmeticService",
                    WellKnownObjectMode.Singleton);

                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(ScientificOperation),
                    "ScientificService",
                    WellKnownObjectMode.Singleton);

                RemotingConfiguration.RegisterWellKnownServiceType(
                    typeof(HistoriqueOperation),
                    "HistoricService",
                    WellKnownObjectMode.Singleton);

                Console.WriteLine("Serveur démarré sur port 8000...");
                Console.WriteLine("Les services suivants sont disponibles :");
                Console.WriteLine("- CalculService");
                Console.WriteLine("- ArithmeticService");
                Console.WriteLine("- ScientificService");
                Console.WriteLine("- HistoricService");
                Console.WriteLine("\nAppuyez sur une touche pour arrêter le serveur...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur: {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}
