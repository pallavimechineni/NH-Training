using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace pgmonQuizApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int score = 0, ans;
            string name;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("Hi {0},Welcome to quiz by pallavi", name);
            Console.WriteLine("Q1.What is National game of USA");
            Console.WriteLine("1.Hockey 2.Football 3.cricket 4.Baseball");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            Console.WriteLine("Q1.What is National game of Australia");
            Console.WriteLine("1.Hockey 2.Football 3.cricket 4.Baseball");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;
            Console.WriteLine("Q1.What is National game of England");
            Console.WriteLine("1.Hockey 2.Football 3.cricket 4.Baseball");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;
            Console.WriteLine("Q1.What is National game of Srilanka");
            Console.WriteLine("1.Hockey 2.vollyball 3.cricket 4.Baseball");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;
            Console.WriteLine("Q1.What is National game of china");
            Console.WriteLine("1.Hockey 2.Football 3.cricket 4.Tabletennis");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            if (score >= 60)
                Console.WriteLine("congratulations {0},you got {1}% in quiz", name, score);
            else
                Console.WriteLine("sorry {0} you got only {1} % try again", name, score);
            StreamWriter sw = new StreamWriter(@"D:\Day1 Assessment by Pallavi Mechineni\Day 15 project\pgmonQuizApplication\scores.txt", true);
            sw.WriteLine(" Name : {0} \n\t Score : {1}\n", name, score);
            sw.Close();

            
            Console.WriteLine("\n\t Congratulations, You got {0} Scores", score);
          
            Console.ReadLine();


        }
    }


}

