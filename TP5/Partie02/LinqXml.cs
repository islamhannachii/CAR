using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Partie02
{
    internal class LinqXml
    {
        XElement contacts;
        /*___________________________________________________________________________*/
        /* 1. Exemple de création d'un arbre XML par analyse syntaxique d'une chaîne */
        public void createXmlAnalyse()
        {
            contacts = XElement.Parse(
            @"<contacts>
 <contact>
 <name> Boulkrinat Samia </name>
<phone type='home'> 206-555-0144 </phone>
 <phone type='work'> 425-555-0145 </phone>
 <address>
 <street> 123 Cité Rabia </street>
<city> Bab-Ezzouar Alger </city>
<state> Algérie </state>
<postal> 16000 </postal>
 </address>
 <netWorth> 10 </netWorth>
 </contact>
 </contacts>");
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
        }

        public void createXmlXelement()
        {
            contacts =
            new XElement("contacts",
            /* Un premier contact ............... */
            new XElement("contact",
            new XElement("name", "Boulkrinat Samia"),
            new XElement("phone",
            new XAttribute("type", "home"), "206-555-0144"),
            new XElement("phone",
            new XAttribute("type", "work"), "425-555-0145"),
            new XElement("address",
            new XElement("street", "123 Cité Rabia"),
            new XElement("city", "Bab-Ezzouar Alger"),
            new XElement("state", "Algérie"),
            new XElement("postal", "16000")),
            new XElement("netWorth", "10")),
           /* Un deuxième contact ............... */
           new XElement("contact",
            new XElement("name", "Benhamouda Ilham"),
            new XElement("phone",
            new XAttribute("type", "mobile"), "562-577-0421"),
            new XElement("phone",
            new XAttribute("type", "work"), "854-858-0985"),
            new XElement("address",
            new XElement("street", "46 Cité Smail yafsah"),
            new XElement("city", "Bab-Ezzouar Alger"),
            new XElement("state", "Algérie"),
            new XElement("postal", "16000")),
            new XElement("netWorth", "20")));
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
        }
        public void requestXml()
        {
            /* 1. Recherhe du noeud ou XElement name dans contact */
            var result =
            from c in contacts.Elements("contact").Elements("name")
            select c;
            /* 2. Affichage de la valeur du XElement name */
            foreach (XElement name in result)
            {
                Console.WriteLine(name.Value);
            }
            Console.WriteLine(); Console.WriteLine();
        }
        public void updateXml()
        {
            XElement mobilephone = new XElement("mobilephone",
            new XAttribute("type", "mobile"), "206-333-4546");
            Console.WriteLine("1. Ajout d'un nouveau mobilephone dans contact (par ordre)....."); Console.WriteLine();
            contacts.Element("contact").Add(mobilephone);
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("2. Supression d'un contact (par ordre) .....");
            Console.WriteLine();
            contacts.Element("contact").Remove();
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("2bis. Supression d'un contact (par ordre) .....");
            Console.WriteLine();
            contacts.Element("contact").Remove();
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("3. Supression d'un phone du contact restant .....");
            Console.WriteLine();
            contacts.Element("contact").Element("phone").Remove();
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("4. Ajout d'un nouveau mobilephone du contact restant .....");
            Console.WriteLine();
            contacts.Element("contact").Add(mobilephone);
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("5. Remplace la valeur du noeud mobilephone par une premières  valeur....."); Console.WriteLine();
            contacts.Element("contact").Element("mobilephone").ReplaceNodes("7777");
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("6. Remplace la valeur du noeud mobilephone par une deuxième valeur....."); Console.WriteLine();
            contacts.Element("contact").SetElementValue("mobilephone", "9999");
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
        }
        public void saveModif()
        {
            try
            {
            contacts.Save(@"Contacts.xml");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void accessElement()
        {
            Console.WriteLine(); Console.WriteLine("6. Exemple d'accès à l'element d'un noeud:");

            IEnumerable<XElement> result =
            from p in contacts.Elements("contact")
            where (((string)(p.Element("address").Element("street"))).Contains("Rabia"))
            select p;
            foreach (XElement p in result)
            {
                Console.WriteLine((string)p.Element("name") + " habite "
                + (string)p.Element("address").Element("city"));
            }
        }
        public void updateAttrib()
        {
            Console.WriteLine(); Console.WriteLine("8. Exemple de modification de tous les attributs type de phone 'work' par 'urgent' :");
            foreach (var p in contacts.Elements("contact").Elements("phone"))
            {
                if ((string)p.Attribute("type") == "work")
                {
                    p.SetAttributeValue("type", "urgent");
                }
            }
            Console.WriteLine(contacts); Console.WriteLine(); Console.WriteLine();
        }
        public void accessAttrib()
        {
            Console.WriteLine(); Console.WriteLine("7. Exemple d'accès aux attributs d'un élément: ");
            foreach (var p in contacts.Elements("contact").Elements("phone"))
            {
                if ((string)p.Attribute("type") == "mobile")
                {
                    Console.WriteLine("Le téléphone personnel de "
                    + (string)p.Ancestors().Elements("name").First() + "est: " + (string)p);
                }
            }
        }

        public void loadFile()
        {
            XElement contactsFromFile = XElement.Load(@"Contacts.xml");
            Console.WriteLine(contactsFromFile);
        }


    }
}
