using System;

namespace pgm
{    class autop
    {
        public string name { get; set; }
        public string location { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            autop data = new autop();
            data.name = "Ram";
            data.location = "hyd";
            Console.WriteLine("name is " + data.name);
            Console.WriteLine("lacation is " +data. location);

                
        }
    }
}
