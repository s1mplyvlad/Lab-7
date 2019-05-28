using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] myRooms = new Room[5];

            myRooms[0] = new MyRoom(5, 6, 11);

            myRooms[1] = new MyRoom(4, 3, 6);

            myRooms[2] = new MyRoom(2, 7, 10);

            myRooms[3] = new MyRoom(11, 6, 4);

            myRooms[4] = new MyRoom(5, 5, 2);

            Array.Sort(myRooms);

            Console.WriteLine("Вiдсортованi кiмнати за площею : ");

            foreach (Room room in myRooms)
            {

                Console.Write(room.SquareRoom() + " ");

            }

            Console.WriteLine();

            ClassRoom classRoom = new ClassRoom(11, 6, 10);

            if ((classRoom.Compare((MyRoom)myRooms[0], (MyRoom)myRooms[1])) == 1)
            {

                Console.WriteLine("У першiй класній кiмнаті бiльше вiкон!");

            }
            else if (classRoom.Compare((MyRoom)myRooms[0], (MyRoom)myRooms[1]) == -1)
            {

                Console.WriteLine("У другiй класнiй кiмнатi бiльше вiкон!");

            }
            else { Console.WriteLine("Кiлькість вiкон однакова!"); }


        }
    }
}
