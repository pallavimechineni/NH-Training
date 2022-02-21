using System;
using System.Xml;
namespace pgmonXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Administrator\\OneDrive\\Desktop\\emp2.xml");
            // XmlNode node = doc.DocumentElement.SelectSingleNode(\employees\employee);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
               
                    string text = node.InnerXml;
              
           
           }
            Console.ReadLine();
        }
    }
}




