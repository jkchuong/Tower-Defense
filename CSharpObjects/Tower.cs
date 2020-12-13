using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; }= 0.75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(InterInvader[] invaders)
        {
            foreach (InterInvader invader in invaders)
            {
                if(invader.IsAlive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.Damage(Power);
                        
                        if (invader.IsDead)
                        {
                            Console.WriteLine("Killed invader at " + invader.Location);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Missed invader");
                    }
                    break;
                }
            }
        }
    }
}
