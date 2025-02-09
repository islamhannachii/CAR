using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {

        RemotingInterfaces.IRemoteOperation remoteOperation;
        public Form1()
        {
            InitializeComponent();
            try
            {
                TcpChannel channel = new System.Runtime.Remoting.Channels.Tcp.TcpChannel();
                ChannelServices.RegisterChannel(channel, false);
                remoteOperation = (RemotingInterfaces.IRemoteOperation)Activator.GetObject(
                    typeof(RemotingInterfaces.IRemoteOperation), "tcp://localhost:2004/RemoteOperation");
            }
            catch (Exception es)
            {
                Console.WriteLine(es.ToString());
                Console.WriteLine("Erreur de connexion au serveur");
                Console.ReadLine();
            }
        }
        private void btnCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                double valeur1 = double.Parse(txtValeur1.Text);
                double valeur2 = double.Parse(txtValeur2.Text);
                string operation = cmbOperation.Text;

                switch (operation)
                {
                    case "+":
                        txtResultat.Text = remoteOperation.Sommer((int)valeur1, (int)valeur2).ToString();
                        break;
                    case "-":
                        txtResultat.Text = remoteOperation.Soustraire((int)valeur1, (int)valeur2).ToString();
                        break;
                    case "*":
                        txtResultat.Text = remoteOperation.Multiplier((int)valeur1, (int)valeur2).ToString();
                        break;
                    case "/":
                        txtResultat.Text = remoteOperation.Diviser((int)valeur1, (int)valeur2).ToString();
                        break;
                    case "sqrt":
                        txtResultat.Text = remoteOperation.Racine(valeur1).ToString();
                        break;
                    case "pow":
                        txtResultat.Text = remoteOperation.Puissance(valeur1, valeur2).ToString();
                        break;
                    case "%":
                        txtResultat.Text = remoteOperation.Pourcentage(valeur1).ToString();
                        break;
                    case "frac":
                        txtResultat.Text = remoteOperation.Fraction(valeur1).ToString();
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de calcul: " + ex.Message);
            }
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            try
            {
                var historique = remoteOperation.AfficherHistorique();
                listHistorique.Items.Clear();
                foreach (var item in historique)
                {
                    listHistorique.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'accès à l'historique: " + ex.Message);
            }
        }
    }
}
