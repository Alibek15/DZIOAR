using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            double[] array = new double[18];
            double[] array2 = new double[18];
            Random rand = new Random();

            for (int i = 0; i < 8; i++)

            {
                array[i] = rand.Next(-50, 50);

                WriteLine((array[i]));

            }
            ResetColor();
            WriteLine("-------------------------");
            ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 8; i++) //i<18
            {
                array2[i] = 0.13 * array[i] * array[i] * array[i] - 2.5 * array[i] + 8.0;
                WriteLine(array2[i]);
}
            ReadKey();

        }
    }
}
