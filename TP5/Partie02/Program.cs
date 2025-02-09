using System;

namespace Partie02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*____________________________*/
            /* Partie 2 : LINQ to XML */
            ///*____________________________*/
            LinqXml lx = new LinqXml();
            lx.createXmlAnalyse();
            lx.createXmlXelement();
            lx.requestXml();
            lx.updateXml();
            lx.saveModif();
            lx.accessElement();
            lx.accessAttrib();
            lx.updateAttrib();
            lx.loadFile();
 
            Console.ReadLine();
        }
    }
}
