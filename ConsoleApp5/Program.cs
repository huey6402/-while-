using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("    *    ");
               Console.WriteLine("   ***   ");
               Console.WriteLine("  *****  ");
               Console.WriteLine(" ******* ");
               Console.WriteLine("*********"); */

            int floor, star , A;
            floor = 1;
            A = floor;
            star = 1;

            while (floor <= 5)
            {
                {
                    while (floor <= 5)
                    {
                        Console.Write(" ");
                        floor = floor + 1;
                    }
                }
                star = star * 2 - 1;
                while (star >= 1)
                {
                    Console.Write("*");
                    star = star - 1;
                }

                Console.WriteLine("");
                A = A + 1;
                floor = A;
                star = A;
            }
        }
        
    }
}
