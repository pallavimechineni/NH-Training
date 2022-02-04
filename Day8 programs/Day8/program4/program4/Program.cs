using System;
using System.Linq;
namespace Day8
{
    internal class Program
    {
        class Games
        {
            public int Id;
            public string Name;
            public string gamename;
        }
        static void Main(string[] args)
        {
            Games[] player = new Games[]
            {
                new Games(){Id = 1, Name = "p.v .sindhu", gamename ="shuttle"},
                new Games(){Id = 2, Name = "ram", gamename = "carroms"},
                new Games(){Id = 3, Name = "sachin", gamename = "cricket"},
                new Games(){Id = 4, Name = "kohli", gamename = "cricket"},
                new Games(){Id = 5, Name = "kapil", gamename = "volleyball"},

            };
            //playere list by using for loop
            Console.WriteLine("player listby using for loop ");
            for (int i = 0; i < player.Length; i++)
            {

                Console.WriteLine($"player id = {player[i].Id}, playerName = {player[i].Name},  gamename ={player[i].gamename}");
            }
            //player list by using foreach loop
            Console.WriteLine("player listby using foreach loop ");

            foreach (var e in player)
            {
                Console.WriteLine($"player id = {e.Id}, playerName = {e.Name},  gamename ={e.gamename}");
            }

            player.ToList().ForEach(e => Console.WriteLine($"player id = {e.Id}, playerName = {e.Name},  gamename ={e.gamename}"));
            Console.ReadLine();
            //player list by using LINQ
            Console.WriteLine("player listby using LINQ  ");
            var result = from d in player
                         where d.Id != 0
                         select d;
            //palyerv list using lamda expression.
            Console.WriteLine("player listby using lamda loop ");
            result.ToList().ForEach(e => Console.WriteLine(e));
            Console.ReadLine();
        }
        }
    }



