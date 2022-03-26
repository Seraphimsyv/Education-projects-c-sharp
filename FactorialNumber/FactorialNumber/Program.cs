using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input num for found factorial: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial num " + Convert.ToString(num) + " = " + Convert.ToString(Factorial(num)));
            Console.ReadLine();
        }

        static int Factorial(int num, int res = 0)
        {
            if (num == 1)
            {
                return res;
            }
            else
            {
                num = num - 1;
                res = num * num;
                return num * Factorial(num, res);
            }
        }
    }
}
