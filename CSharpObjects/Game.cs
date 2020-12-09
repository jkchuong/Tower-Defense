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
            Point point = new Point(10, 1);

            int area = map.Width * map.Height;


            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Co-ords: ({point.X},{point.Y})");
            
            if (map.OnMap(point) == true)
            {
                Console.WriteLine("The point is within the area.");
            }
            else
            {
                Console.WriteLine("The point is out of bounds");
            }

            Console.ReadKey();
        }
    }
}
