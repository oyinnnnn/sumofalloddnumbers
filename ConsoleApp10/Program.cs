using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            

            {
                int i, limit = 100, sumOdd = 0;
                Console.WriteLine("100:");

                limit = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i <= 100; i += 2)
                {
                    sumOdd += i;
                }

                Console.WriteLine("Total sum: " + sumOdd);
                Console.ReadLine();
            }
        }

    }

}
