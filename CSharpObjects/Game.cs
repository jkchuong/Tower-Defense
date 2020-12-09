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

            try
            {
                MapLocation point1 = new MapLocation(10, 1, map);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }


            int area = map.Width * map.Height;



            Console.ReadKey();
        }
    }
}
