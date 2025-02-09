using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using RemotingInterfaces;

namespace RemotingClient
{
    [Serializable]
    public partial class Form1 : Form
    {
        IRemoteOperation remoteOperation;

        public Form1()
        {
            InitializeComponent();
            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, false); // false : en cas de pb a changer
                remoteOperation =
                (RemotingInterfaces.IRemoteOperation)Activator.GetObject(
                typeof(RemotingInterfaces.IRemoteOperation),
                "tcp://localhost:2500/RemoteOperation");
            }
            catch { MessageBox.Show("Erreur de connexion au serveur"); }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            remoteOperation.insererE(nom.Text, prenom.Text, Int32.Parse(matricule.Text));
            MessageBox.Show("Ecrivain a ete ajoute avec succes");
            remoteOperation.insererL(Int32.Parse(code.Text),titre.Text,langue.Text,Int32.Parse(annee.Text),Int32.Parse(matricule.Text));
            MessageBox.Show("Livre a ete ajoute avec succes");

        }

        private void label8_Click(object sender, EventArgs e)
        {
            XElement e1 = new XElement("catalogue",
                    new XElement("Auteur",
                            new XElement("name", "islam hannachi"),
                            new XElement("phone", "islam hannachi"),
                            new XElement("adress", "hgjdsjka")
                            
                    )   
                );

            string path = @"C:\Users\Chamso\source\repos\CAR\FinalTest\Catalogues.xml";
            remoteOperation.ajouterCatalogue(e1.ToString(), path);
        }
    }
}
