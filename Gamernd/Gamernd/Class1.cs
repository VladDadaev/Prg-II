using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamernd
{
    class Class1
    {
        static void Main(string[] args)
        {
            int number;
            Program program = new Program();
            number = program.Randomchik();     
            //Console.WriteLine(number);
            for (int i = 0; i < 100; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine("You lose");
                    break;
                }

                Console.WriteLine("Input number");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == number)
                {
                    Console.WriteLine("You Win!");
                    break;
                }
                else if (x < number)
                {
                    Console.WriteLine("твое число меньше заданого");
                }

                else if (x > number)
                {
                    Console.WriteLine("твое число больше заданого");
                }
            }

            Console.ReadKey();
        }
    }
}
