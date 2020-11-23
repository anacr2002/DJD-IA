using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int p1X= r.Next(501);
            int p1Y = r.Next(501);

            int p2X = r.Next(501);
            int p2Y = r.Next(501);

            double hip = Math.Sqrt(p1X * p2X + p1Y * p2Y);

            if (hip < 20)
            {
                Console.WriteLine("player 2 is out of the map");
            }
            else
            {
                Console.WriteLine("player2 stays");
            }
            
            






        }
    }
}
