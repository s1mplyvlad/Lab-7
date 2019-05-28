using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Square : IMeasurable, IComparable
    {

        public double Side { get; set; }

        public double Perimeter()
        {

            return 4 * Side;

        }

        public double Area()
        {

            return Math.Pow(Side, 2);

        }

        public int CompareTo(object o)
        {

            Square square = o as Square;

            if (square != null)
            {

                return this.Perimeter().CompareTo(square.Perimeter());

            }
            else { throw new Exception("Неможливо порівняти об'єкти!"); }

        }


    }
}