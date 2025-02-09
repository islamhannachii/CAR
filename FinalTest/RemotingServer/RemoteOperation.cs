using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using Diffusion;
using Ecrivain;
using Livre;
using RemotingInterfaces;
namespace RemotingServeur
{
    public class RemoteOperation: MarshalByRefObject, IRemoteOperation
    {
        /*-------------------------------------------------------------------*/
        // Indique que l'objet aura une durée de vie illimitée
        public override object InitializeLifetimeService()
        {
            return null;
        }
        //public void Hello() {
        //    Console.WriteLine("Hello world");
        //}

        public void insererE(string nom, string prenom, int matricule)
        {
            Diffusion.Ecrivain e1 = new Diffusion.Ecrivain() { Nom= nom, Prenom=prenom, Matricule= matricule};
            diffuser diffuser = new diffuser();
            diffuser.insererE(e1, new Ecrivain.Ecri());
            Console.WriteLine("L'ecrivain ayant le matricule "+matricule+"a ete ajoute avec success");

        }

        public void insererL(int code, string titre, string langue, int annee, int matricule)
        {
            Diffusion.Livre e1 = new Diffusion.Livre() { Code= code, Titre=titre, Langue=langue, Annee =annee, Matricule= matricule};
            diffuser diffuser = new diffuser();
            diffuser.insererL(e1, new Ecrivain.Ecri());
            Console.WriteLine("Le livre ayant le code " + code + "a ete ajoute avec success");
        }
        public void ajouterCatalogue(string ele, string path)
        {
            XElement element = XElement.Parse(ele);
            Ecrivain.Livres livre1 = new Ecrivain.Livres();
            livre1.ajouterCatalogue(element, path, new Livre.GestionDeLivre());
            livre1.afficherCatalogues(path, new Livre.GestionDeLivre());

            Console.WriteLine("Pour l'inventaire");
           Livre.Inventaire inv = new Livre.Inventaire();
            inv.afficherCatalogueLivre(path, new Inventaire.Rep());
        }
    }
}
