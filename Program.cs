using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class ILONA
    {
        static void Main(string[] args)
        {
           /* Console.Write("введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("ввведите точность выборки ");
            int n = Convert.ToInt32(Console.ReadLine());
            double s = x;
            double a = 1;
            double b = 1;
            int c = n;
            int f = 0;
            int d = 0;
            while (f < n) 
            {
                a = 1; b = 1;
                while (d <= n)
                {
                    a *= b;
                    b++;
                    Console.WriteLine("1 " + a);
                    d++;
                }
                Console.WriteLine(s);
                s += Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / a;
                n--;
            }
            Console.WriteLine("значение sinx =" + s);
            Console.ReadKey();
        }
    }
}
