using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class BasicInvader : Invader
    {
        public BasicInvader(Path path) : base(path)
        { }

        public override int Health { get; protected set; } = 2;

        public override void Damage(int factor)
        {
            Health -= factor;
            Console.WriteLine("Hit Basic Invader");
        }
    }
}
