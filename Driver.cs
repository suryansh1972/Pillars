using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    public class Driver
    {
        static void Main(string[] args)
        {
            List<Creator> creators = new List<Creator>() { new Youtuber(), new Programmer() };
            foreach (var creator in creators)
            {
                creator.Create();
                Console.WriteLine("Losers");
            }
        }
    }
}
