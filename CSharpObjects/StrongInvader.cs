using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class StrongInvader : Invader
    {
        public StrongInvader(Path path) : base(path)
        {
            
        }

        public override int Health { get; protected set; } = 4;
    }
}
