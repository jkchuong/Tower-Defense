﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class ShieldedInvader : Invader
    {
        private static Random _random = new Random();

        public ShieldedInvader(Path path) : base(path)
        {
            
        }


        // Polymorphism
        public override void Damage(int factor)
        {
            if (_random.NextDouble() < 0.5)
            {
                base.Damage(factor);
            }
            else
            {
                Console.WriteLine("Shot blocked by Shielded Invader.");
            }
        }
    }
}
