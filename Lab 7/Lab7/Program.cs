using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер стороны первого квадрата : ");

            double firstSide = Convert.ToDouble(Console.ReadLine());

            Square first = new Square();

            first.Side = firstSide;

            Console.WriteLine("Периметр - {0:f2}\nПлощадь - {1:f2}", first.Perimeter(), first.Area());

            Console.WriteLine("Введите размер стороны второго квадрата : ");

            double secondSide = Convert.ToDouble(Console.ReadLine());

            Square second = new Square();

            second.Side = secondSide;

            Console.WriteLine("Периметр - {0:f2}\nПлощадь - {1:f2}", second.Perimeter(), second.Area());

            if (first.CompareTo(second) == 0)
            {

                Console.WriteLine("Периметры двох квадратов одинаковые!");

            }
            else if (first.CompareTo(second) == 1)
            {

                Console.WriteLine("Периметр первого квадрата больше, чем периметр второго!");

            }
            else
            {

                Console.WriteLine("Периметр второго квадрата больше, чем периметр первого");

            }


        }
    }
}
