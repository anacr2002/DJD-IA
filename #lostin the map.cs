using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int posX = r.Next(501);
            int posY = r.Next(501);

            if (posX < 250 && posY < 250)
            {
                Console.WriteLine(" Bottom-Left");
            }
            else
            {
                if (posX < 250 && posY > 250)
                {
                    Console.WriteLine("Top-Left");
                }
                else
                {
                    if (posX > 250 && posY > 250)
                    {
                        Console.WriteLine("Top-Right");
                    }
                    else
                    {
                        if (posX > 250 && posY < 250)
                        {
                            Console.WriteLine("Bottom-Right");
                        }
                            }
                    }
                }
                }
            }
        }
    

