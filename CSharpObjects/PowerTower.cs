using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class PowerTower : Tower
    {
        public PowerTower(MapLocation location) : base(location)
        {

        }

        protected override double Accuracy => 0.7;
        protected override int Power => 2;
    }
}
