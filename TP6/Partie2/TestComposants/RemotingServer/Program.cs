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
              try {
                    try
                    {
                        // Création d'un nouveau canal d'écoute sur le port 2004
                        TcpChannel channel = new TcpChannel(2004);
                        // Enregistrement du canal              
                        ChannelServices.RegisterChannel(channel, false);

                        // Démarrage de l'écoute en exposant l'objet en Singleton
                        RemotingConfiguration.RegisterWellKnownServiceType(
                            typeof(RemotingServer.RemoteOperation), "RemoteOperation",
                            WellKnownObjectMode.Singleton);
                        Console.WriteLine("Le serveur a démarré avec succés");
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Erreur lors du démarrage du serveur");
                        Console.ReadLine();
                    }
                    Console.ReadLine();           
			} catch {               
				Console.WriteLine("Erreur lors du démarrage du serveur");               
				Console.ReadLine();           
			}    

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
