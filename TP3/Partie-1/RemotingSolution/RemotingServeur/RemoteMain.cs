using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
namespace RemotingServeur
{
    public class RemoteMain
    {
        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                // Création d'un nouveau canal d'écoute sur le port 1069
                TcpChannel channel = new TcpChannel(2500);
                // Enregistrement du canal
                ChannelServices.RegisterChannel(channel, false); // false : en cas de pb
                                                                // Démarrage de l'écoute en exposant l'objet en Singleton
                RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(RemoteOperation), "RemoteOperation",
                WellKnownObjectMode.Singleton);
                Console.WriteLine("Le serveur a démarré avec succès");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Erreur lors du démarrage du serveur");
                Console.ReadLine();
            }
        }
    }
}