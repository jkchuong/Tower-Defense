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

                InterInvader[] invaders =
                {
                    new FastInvader(path),
                    new BasicInvader(path),
                    new StrongInvader(path),
                    new ShieldedInvader(path),
                    new ResInvader(path)
                };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(2, 3, map)),
                    new PowerTower(new MapLocation(3, 3, map)),
                    new LongTower(new MapLocation(4, 3, map)),
                    new PowerTower(new MapLocation(5, 3, map)),
                    new Tower(new MapLocation(1, 1, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();
                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
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



            Console.ReadKey();
        }
    }
}
