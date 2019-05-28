using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class MyRoom : Room, IComparable
    {
        public MyRoom()
        {

        }

        public MyRoom(double width, double length, int windowsCount)
        {

            this.Width = width;

            this.Length = length;

            this.WindowsCount = windowsCount;

        }

        public double Width { get; }

        public double Length { get; }

        public int WindowsCount { get; }

        public double SquareRoom()
        {

            return Width * Length;

        }

        public int CompareTo(object o)
        {

            MyRoom room = o as MyRoom;

            if (room != null)
            {

                return this.SquareRoom().CompareTo(room.SquareRoom());

            }
            else { throw new Exception("Сравнять обьекты невозможно!"); }

        }

    }
}
