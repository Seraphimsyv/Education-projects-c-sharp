using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица температур по фаренгейту и цельсию");
            Console.WriteLine("По френгейте и цельсию");

            int lower, upper, step;
            double fahr, cels;

            lower = 0;
            upper = 300;
            step = 20;

            fahr = lower;

            while(fahr <= upper)
            {
                cels = (5.0 / 9.0) * (fahr - 32.0);
                Console.WriteLine("{0:f} {1:f}", fahr, cels);

                fahr = fahr + step;
            }

            Console.Write("Для продолжения нажмите любую клавишу");
            Console.ReadKey(true);

        }
    }
}
