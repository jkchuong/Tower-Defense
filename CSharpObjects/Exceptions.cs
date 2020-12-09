using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class TowerDefenseException : Exception
    {
        public TowerDefenseException()
        {

        }
        public TowerDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }

        
    }
}
