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
                Path path = new Path(
                    new[]
                    {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                 );

                Invader invader = new Invader();
                MapLocation location = new MapLocation(0, 0, map);


                location = invader.Location;


            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex);
            }
            catch(TowerDefenseException)
            {
                Console.WriteLine("Unhandled TowerDefenseException.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }


            int area = map.Width * map.Height;

            Console.ReadKey();
        }
    }
}
