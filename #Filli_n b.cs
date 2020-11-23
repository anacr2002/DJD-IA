using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[10];

            for(int i=0; i<5; i++)
            {
                valores[i] = i + 1;
                valores[i + 5] = (i * 10);
            }
        }
    }
}
