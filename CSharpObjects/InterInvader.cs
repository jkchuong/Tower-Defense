using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    interface IMapppable
    {
        MapLocation Location { get; }
    }

    interface IMoveable
    {
        void Move();
    }


    interface InterInvader : IMapppable, IMoveable
    {
       
        int Health { get; }

        bool HasScored { get; }

        bool IsDead { get; }

        bool IsAlive { get; 

        void Damage(int factor);
    }
}

