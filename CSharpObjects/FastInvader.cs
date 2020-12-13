using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class FastInvader : Invader
    {
        public FastInvader(Path path) : base(path)
        { }

        protected override int StepSize { get; } = 2;

        public override void Damage(int factor)
        {
            Health -= factor;
            Console.WriteLine("Hit Fast Invader");
        }
    }
}
