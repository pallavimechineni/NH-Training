using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Day_15_Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filename = @"D:\Day1 Assessment by Pallavi Mechineni\Day 15 project\filepgm.txt";

            StreamWriter sw = File.CreateText(filename);
            sw.WriteLine(" the first File program  C# code");

            sw.WriteLine(" ");
            sw.WriteLine("Writing Data by StringWriter Method.");
            sw.Write("This string  Write Method");
            sw.Write("This is WriteLine  Method");
            sw.Close();

            
            sw = File.AppendText(filename);// Appending Text in file
            sw.WriteLine("This");
            sw.WriteLine("is Extra");
            sw.WriteLine("Text");
            Console.WriteLine("File is appended.");

            sw.Close();
            StreamReader sr = File.OpenText(filename);
            string s;
            
            while ((s = sr.ReadLine()) != null)
                Console.WriteLine(s);

            sr.Close();

            string fileNew = @"D:\Day1 Assessment by Pallavi Mechineni\Day 15 project\filepgm2.txt";
            // Moving a File From One Path to Another Path
            if (File.Exists(fileNew))
                File.Delete(fileNew);
            Console.WriteLine("Already the File is Present, So Deleting the old file & Creating a New File.");

            File.Move(filename, fileNew);
            Console.WriteLine(" Moved to New Path, Successfuly ");
            File.Copy(fileNew, filename);
            Console.WriteLine("File Copying is Done Successfully, to old Path\n");

            // Opening first File
            File.OpenText(filename).Close();
            Console.WriteLine("File opened Successfully");
            string appendText = "This is an Extra text ";
            File.AppendAllText(filename, appendText, Encoding.UTF8);

            Console.WriteLine("File Appended with Extra Text , Successfully");

            string readText = File.ReadAllText(filename);
            Console.WriteLine(" Reading All Text From the File\n");
            Console.WriteLine(readText);

            Console.ReadLine();
        }
    }
}

        
   
