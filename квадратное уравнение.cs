using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("введите значение а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double D = (Math.Pow(b, 2) - (4 * a * c));
             if (D > 0)
            {

                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"уравнение имеет два действительных корня: {x1},{x2} ");
            }
              if (D == 0)
            {

                double x = -b / (2 * a);

                Console.WriteLine($"уравнение имеет два равных корня: {x}={x} ");
            }
             else (D < 0)
            { 
                double f = -b / (2 * a);
                double f2 = Math.Sqrt(-D) / (2 * a);
                Console.WriteLine($"уравнение имеет два комплексных корня: {f + f2}i, {f - f2}i ");
            }
            













































            Console.ReadKey();


        }
    }
}
