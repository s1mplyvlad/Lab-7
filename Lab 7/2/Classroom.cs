using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class ClassRoom : Room, IComparer<MyRoom>
    {
        public ClassRoom()
        {

        }

        public ClassRoom(double width, double length, int windowsCount)
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

        public int Compare(MyRoom first, MyRoom second)
        {

            if (first.WindowsCount > second.WindowsCount)
            {

                return 1;

            }
            else if (first.WindowsCount < second.WindowsCount)
            {

                return -1;

            }
            else
            {

                return 0;

            }

        }

    }
}
