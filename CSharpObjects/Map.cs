using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        // Constructor Method - Required for object to be built
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
