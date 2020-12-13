using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class LongTower : Tower
    {
        public LongTower(MapLocation location) : base(location)
        {
            
        }

        protected override int Range { get; } = 3;
        protected override double Accuracy => 0.70;
    }
}
