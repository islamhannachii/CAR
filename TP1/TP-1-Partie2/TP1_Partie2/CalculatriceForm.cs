
using System.Xml.Serialization;

namespace TP1_Partie2
{
    public partial class CalculatriceForm : Form
    {
        public string Operande;
        public string Operateur;
        public CalculatriceForm()
        {
            InitializeComponent();
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
        private void Egale(object sender, EventArgs e)
        {

            switch (Operateur)
            {
                case "+":
                    Resultat.Text = (double.Parse(this.Operande) + double.Parse(Resultat.Text)).ToString();
                    break;
                case "-":
                    Resultat.Text = (double.Parse(this.Operande) - double.Parse(Resultat.Text)).ToString();
                    break;
                case "*":
                    Resultat.Text = (double.Parse(this.Operande) * double.Parse(Resultat.Text)).ToString();
                    break;
                case "/":
                    if (Resultat.Text == "0")
                    {
                        MessageBox.Show("On ne peut pas diviser par 0 :");
                    }
                    else
                    {
                        Resultat.Text = (double.Parse(this.Operande) / double.Parse(Resultat.Text)).ToString();
                    }
                    break;
                case "1/x":
                    if (this.Operande == "0")
                    {
                        MessageBox.Show("On ne peut pas diviser par 0 :");

                    }
                    else
                    {
                        Resultat.Text = (1 / (double.Parse(this.Operande))).ToString();

                    }
                    break;
                case "√":
                    if (double.Parse(this.Operande) < 0)
                    {
                        MessageBox.Show("On ne peut pas opter la racine carre d'un numero negatif.");

                    }
                    else
                    {
                        Resultat.Text = (Math.Sqrt(double.Parse(this.Operande))).ToString();

                    }
                    break;
                case "%":
                    Resultat.Text = ((double.Parse(this.Operande))*0.01).ToString();

                    break;
            }
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
