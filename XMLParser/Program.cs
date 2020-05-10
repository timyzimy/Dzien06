using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = @"c:\tmp\persons.xml";
            String content = File.ReadAllText(fileName);

            XmlDocument document = new XmlDocument();
            document.LoadXml(content);

            XmlElement persons = document["persons"];
            Console.WriteLine("Liczba elementów w 'persons' " + persons.ChildNodes.Count);

            foreach (XmlElement item in persons.ChildNodes)
            {
                string fname = item.GetAttribute("name");
                string lname = item.GetAttribute("lname");
                string phone = item.GetAttribute("phone");
                Console.WriteLine("{0}\t{1}\t{2}", fname, lname, phone);
            }

            Console.ReadKey();

        }
    }
}
