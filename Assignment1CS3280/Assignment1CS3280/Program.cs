using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1CS3280
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStrings();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }


        public static void PrintStrings()
        {
            Random rnd = new Random();
            int rndValue = rnd.Next(0, 10);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    rndValue = rnd.Next(0, 10);
                    if (rndValue < 3)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write('o');
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
