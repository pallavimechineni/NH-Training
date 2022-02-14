using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pgmonTasksched
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            string filePath = @"D:\Day1 Assessment by Pallavi Mechineni\Day 15 project\filepgm.txt";

            string TaskSchedPath = @"C:\Users\Administrator\OneDrive\Desktop\ConsoleApp4\filepgm2.txt";
            if (File.Exists(TaskSchedPath))
                File.Delete(TaskSchedPath);

            File.Copy(filePath, TaskSchedPath);

            Console.WriteLine("File Copying is Done");

            
            Console.ReadKey();




        }
  
    }

}
