using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class Game
    {
        public static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            MapLocation point1 = new MapLocation(10, 1);
            MapLocation point2 = new MapLocation(4, 4);

            int area = map.Width * map.Height;


            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Co-ord 1: ({point1.X},{point1.Y})");
            Console.WriteLine($"Co-ord 2: ({point2.X},{point2.Y})");
            
            if (map.OnMap(point1) == true)
            {
                Console.WriteLine("The point is within the area.");
            }
            else
            {
                Console.WriteLine("The point is out of bounds");
            }

            Console.WriteLine(point1.DistanceTo(point2));

            Console.ReadKey();
        }
    }
}
