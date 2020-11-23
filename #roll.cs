using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int p1 = r.Next(7);

            int p2 = r.Next(7);

            if (p1 > p2)
            {
                Console.WriteLine("p1 wins!");

            } else {
                Console.WriteLine("p2 wins!");
            }
        }
    }
}
