using System;
using System.Net;
using System.Net.Sockets;
namespace Calculatrice
{
    class client
    {
        private int clientPort = -1; //port du client
        private int serveurPort = -1; //port du serveur
        private string serveurHost = null; //adresse du serveur
        UdpClient Client = null; //le client
                                 //constructeur
        public client(int clientPort, string serveurHost, int serveurPort)
        {
            this.clientPort = clientPort;
            this.serveurHost = serveurHost;
            this.serveurPort = serveurPort;
            this.Client = new UdpClient(clientPort);
        }
        public void Close() { this.Client.Close(); }
        public bool Execute(string command, ref string resultat)
        {
            bool ok = true;
            //commande a envoyer
            string req = "127.0.0.1:" + this.clientPort + ":" + command;
            //conversion de la commande en byte
            byte[] rq = System.Text.Encoding.ASCII.GetBytes(req.ToCharArray());
            //envoi de la commande
            Client.Send(rq, rq.Length, this.serveurHost, this.serveurPort);
            //variable de reception du resultat
            IPEndPoint ip = null;
            //reception
            byte[] r = Client.Receive(ref ip);
            //conversion
            resultat = System.Text.Encoding.ASCII.GetString(r);
            ok = !resultat.Equals(0);
            return ok;
        }
    }
}