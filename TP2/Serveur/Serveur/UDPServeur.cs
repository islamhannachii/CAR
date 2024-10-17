using System.Net;
using System.Net.Sockets;
namespace UdpServeur
{
    class serveur
    {
        static void Main(string[] args)
        {
            int P = 8080; //port de connexion
            IPEndPoint ip = null;
            //Demarage su serveur
            Console.WriteLine("Demarage du serveur...");
            UdpClient serveur = new UdpClient(P);
            bool loop = true;
            while (loop)
            {
                //Attente de connexion
                Console.WriteLine("Attente de connexion(s)...");
                byte[] tmp = serveur.Receive(ref ip);
                //Conversion des bytes en string (chaine de caractere)
                string data = new System.Text.ASCIIEncoding().GetString(tmp);
                //Décodage de la commande -->ip:port:command
                string[] cmd = data.Split(new char[] { ':' });
                    //adresse ip
                string host = cmd[0];
                //port de connexion
                int port = Int32.Parse(cmd[1]);
                //récupération de nb1 du signe et de nb2
                double nb1 = double.Parse(cmd[2]);
                string signe = cmd[3];
                double nb2 = double.Parse(cmd[4]);
                string resultat = "";
                Console.WriteLine("Operation --> " + nb1 + " " + signe + " " + nb2);
                //execution de la commande
                switch (signe)
                {
                    case "+":
                        resultat = (nb1+nb2).ToString();
                        break;
                    case "-":
                        resultat=  (nb1- nb2).ToString();
                        break;
                    case "*":
                        resultat= (nb1 * nb2).ToString();
                        break;
                    case "/":
                        if (nb2 !=0)
                        {
                            resultat = (nb1 / nb2).ToString();
                        }
                        else
                        {
                            resultat = "Erreur";
                        }
                        break;
                    case "1/x":
                        if (nb1 != 0)
                        {
                            resultat = (1 / nb1).ToString();
                        }
                        else
                        {
                            resultat = "Erreur";

                        }
                        break;
                    case "r":
                        if (nb1 >= 0)
                        {
                            resultat = (Math.Sqrt(nb1)).ToString();
                        }
                        else
                        {
                            resultat = "Erreur";

                        }
                        break;
                    case "%":
                        resultat = (nb1 * 0.01).ToString();
                        break;
                }

             
                //conversion du resultat en bytes
                byte[] rep = System.Text.Encoding.ASCII.GetBytes(resultat);
                serveur.Send(rep, rep.Length, host, port);
            }//fin du while/
             //arret du serveur
            Console.WriteLine("Arret du serveur...");
            Console.WriteLine("Arret du serveur... *Entree* pour terminer.");
            Console.ReadLine();
        }
    }
}
