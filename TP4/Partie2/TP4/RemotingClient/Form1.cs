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
using RemotingInterfaces;
namespace RemotingClient
{
    public partial class Form1 : Form
    {
        RemotingInterfaces.IRemoteOperation remoteOperation;
        public Form1()
        {
            InitializeComponent();
            try
            {
                TcpChannel channel = new TcpChannel();
                ChannelServices.RegisterChannel(channel, false);
                remoteOperation =
                (RemotingInterfaces.IRemoteOperation)Activator.GetObject(
                typeof(RemotingInterfaces.IRemoteOperation),
                "tcp://127.0.0.1:2500/RemoteOperation");
                remoteOperation.Connect();

            }
            catch { 
                //statusStrip.Text = "Erreur de connexion au serveur";
            }
            


        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                remoteOperation.AjouterUnCours(Int32.Parse(code.Text), designation.Text, Int32.Parse(volume.Text), category.Text.ToString());
                MessageBox.Show("Cours ajoute");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dvSample = remoteOperation.GetData("Cours");

            table.DataSource = dvSample;
        }

        private void category_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(nom.Text + prenom.Text + telephone.Text + email.Text);
            try
            {
                remoteOperation.AjouterUnEnseigant(Int32.Parse(matricule.Text), nom.Text, prenom.Text, telephone.Text,Int32.Parse(experience.Text), grade.Text, email.Text);
                MessageBox.Show("Enseigant ajoute");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataTable dvSample = remoteOperation.GetData("Enseignant");
            table.DataSource = dvSample;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void compter_Click(object sender, EventArgs e)
        {
            compterBox.Text = remoteOperation.CompterEnseigne().ToString();

        }

        private void ajouter_Enseigne_Click(object sender, EventArgs e)
        {
            try
            {
                remoteOperation.AjouterUnEnseigne(Int32.Parse(matricule.Text), Int32.Parse(code.Text));
                MessageBox.Show("Enseigne ajoute");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void afficher_enseigne_Click(object sender, EventArgs e)
        {
            DataTable dvSample = remoteOperation.GetData("Enseigne");
            table.DataSource = dvSample;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            remoteOperation.Supprimer("COURS", Int32.Parse(code.Text));
            MessageBox.Show("Cours a ete bien supprime");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            remoteOperation.Supprimer("enseignant", Int32.Parse(matricule.Text));
            MessageBox.Show("Cours a ete bien supprime");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dvSample =remoteOperation.Join();
            table.DataSource = dvSample;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            remoteOperation.SupprimerEnseigne(Int32.Parse(code.Text), Int32.Parse(matricule.Text));
            MessageBox.Show("Enseigne a ete bien supprime");
        }
        //_______________________________
    }

}
