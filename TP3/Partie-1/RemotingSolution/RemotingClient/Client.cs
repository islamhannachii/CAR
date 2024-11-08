using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemotingClient
{
    public partial class Client : Form
    {

        public string Operande;
        public string Operateur;
        private string Quotient;
        private double Operande1, Operande2;
        RemotingInterfaces.IRemoteOperation remoteOperation;
        public Client()
        {
            InitializeComponent();
            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, true); // false : en cas de pb a changer
                remoteOperation =
                (RemotingInterfaces.IRemoteOperation)Activator.GetObject(
                typeof(RemotingInterfaces.IRemoteOperation),
                "tcp://localhost:1069/RemoteOperation");
            }
            catch { Resultat.Text = "Erreur de connexion au serveur"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        // Event handlers (implement these methods according to your logic)

        private void Operation_Click(object sender, EventArgs e)
        {
            this.Operateur = ((Button)sender).Text;
            this.Operande = Resultat.Text;
            switch (this.Operateur)
            {
                case "1/x":
                    this.Egale(sender, e);
                    break;
                case "√":
                    //this.Operateur = "r";
                    this.Egale(sender, e);
                    break;
                case "%":
                    this.Egale(sender, e);
                    break;
                case "+/-": this.Egale(sender, e);
                    break;
                default:
                    Resultat.Text = "0";
                    break;
            }
        }
        private void Egale(object sender, EventArgs e) {

            Operande1 = double.Parse(this.Operande);
            Operande2 = double.Parse(Resultat.Text);
            if (remoteOperation != null)
            {
                switch (this.Operateur)
                {
                    case "/":
                        Quotient = (remoteOperation.Division(this.Operande1,this.Operande2)).ToString();
                        Resultat.Text = Quotient;
                        if (double.Parse(Quotient) == -1)
                        {
                           
                            Console.Write("Division impossible");
                            this.Resultat.Text = "Division impossible";

                        }
                        else
                        {
                            this.Resultat.Text = Quotient;
                        }
                        break;
                    case "*":
                        this.Resultat.Text =
                    (remoteOperation.Multiplication(this.Operande1,
                    this.Operande2)).ToString();
                        this.Resultat.Text = this.Resultat.Text;
                        break;
                    case "-":
                        this.Resultat.Text =
                    (remoteOperation.Soustraction(this.Operande1,
                    this.Operande2)).ToString();
                        break;
                    case "+":
                        this.Resultat.Text = (remoteOperation.Addition(this.Operande1,
                    this.Operande2)).ToString();
                        break;
                    case "√":
                        this.Resultat.Text =
                        (remoteOperation.Racine(this.Operande1)).ToString();
                        break;
                    case "1/x":
                        this.Resultat.Text =
                        (remoteOperation.Fraction(this.Operande1)).ToString();
                        break;
                    case "%":
                    this.Resultat.Text = (remoteOperation.Pourcentage(this.Operande1)).ToString();
                        break;
                    case "+/-":
                        this.Resultat.Text = (remoteOperation.Inverse(this.Operande1)).ToString();
                        break;
                    default:
                        //this.statusStrip.Text = "Opération invalide...";
                        break;
                }
            }
        }

        private void Ecrire(object sender, EventArgs e)
        {
            if (Resultat.Text == "0")
            {
                Resultat.Text = ((Button)sender).Text;
            }
            else
            {
                Resultat.Text += ((Button)sender).Text;
            }
        }
        private void SupprimerTextActuel(object sender, EventArgs e)
        {
            Resultat.Text = "0";

        }
        private void MisAZero(object sender, EventArgs e)
        {
            Operande = "0";
            Resultat.Text = "0";

        }
        private void SupprimerDernierCaractere(object sender, EventArgs e)
        {
            if (Resultat.Text.Length > 0)
            {
                Resultat.Text = Resultat.Text.Substring(0, Resultat.Text.Length - 1);
            }
        }
        //private void Convertir(object sender, EventArgs e)
        //{
        //    Resultat.Text = ((double.Parse(Resultat.Text)) * -1).ToString();
        //}
        private void Point(object sender, EventArgs e)
        {
            Resultat.Text += ".";
        }
    }
}
