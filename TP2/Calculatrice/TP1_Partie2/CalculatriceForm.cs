
using System.Xml.Serialization;

namespace TP1_Partie2
{
    public partial class CalculatriceForm : Form
    {
        public string Operande;
        public string Operateur;
        private Calculatrice.client proc;
        public CalculatriceForm()
        {
            InitializeComponent();
            this.proc = new Calculatrice.client(8081, "192.168.213.65", 8080);
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
            this.Operande = "0";
            Resultat.Text = "0";

        }
        private void Convertir(object sender, EventArgs e)
        {
            Resultat.Text = ((double.Parse(Resultat.Text))* -1).ToString();
        }
        private void Egale(object sender, EventArgs e)
        {
            string command, resultat = "";       
            command = this.Operande + ":" + this.Operateur + ":" + Resultat.Text;
            this.proc.Execute(command, ref resultat);
            Resultat.Text = resultat;


        }

        private void Point(object sender, EventArgs e)
        {
            Resultat.Text += ".";
        }
        private void SupprimerDernierCaractere(object sender, EventArgs e)
        {
            if (Resultat.Text.Length > 0)
            {
                Resultat.Text = Resultat.Text.Substring(0, Resultat.Text.Length - 1);
            }
        }
        
        private void Operation_Click(object sender, EventArgs e)
        {
            this.Operateur = ((Button)sender).Text;
            this.Operande = Resultat.Text;
            switch(this.Operateur)
            {
                case "1/x":
                    this.Egale(sender,e);
                    break;
                case "√":
                    this.Operateur = "r";
                    this.Egale(sender,e);
                    break;
                case "%":
                    this.Egale(sender, e);
                    break;
                default:
                    Resultat.Text = "0";
                    break;
            }
        }
    }
}
