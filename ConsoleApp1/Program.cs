using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             ForegroundColor = ConsoleColor.Yellow;
           
            int[] MyArray = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int Max = MyArray[0];
            int nul = 0;

            


            for (int i = 0; i < MyArray.Length; i++)
            {
                if (Max < MyArray[i])
                {
                    Max = MyArray[i];
                    nul= i;
                }

            }


            MyArray[nul] = MyArray[0];
            MyArray[0] = Max;
            for (int i = 0; i < MyArray.Length; i++)
            {
                WriteLine(MyArray[i]);

            }

            ReadKey();

        }
    }
}
