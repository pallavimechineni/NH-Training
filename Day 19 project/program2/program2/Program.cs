using System;
using System.Xml;

// Author : M.Pallavi
// Purpose : C# Code To read Xml Data from a Xml file & printing the data of Only Names to the Console.

namespace Day19Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Administrator\OneDrive\Desktop\emp1.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "Name")
                    {
                        Console.WriteLine(childNode.InnerText);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
