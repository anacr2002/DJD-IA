using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int a = 52;
            bool a = true;
            while (a)
            {
                int b = r.Next(1, 101);
                if (b < a)
                {
                    Console.WriteLine("guess a lower number!");
                }

            }
        }
    }
}
