using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class Invader
    {
        // Fields. Things that Invader has.
        private readonly Path _path;
        private int _pathStep = 0;

        // Property. Info about Invader. Properties always return value.
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public int Health { get; private set; } = 2;
        public bool HasScored { get { return _pathStep >= _path.Length; } }
        public bool IsDead => Health <= 0;
        public bool IsAlive => !(IsDead || HasScored);

        // Constructor. Info needed to make Invader
        public Invader(Path path)
        {
            _path = path;
        }

        // Method. Stuff you can do to Invader. Methods have brackets.
        public void Move() => _pathStep += 1;
        public void Damage(int factor) => Health -= factor;
    }
}
