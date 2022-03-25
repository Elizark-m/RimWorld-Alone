using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimAlone
{
    class Coordinate
    {
        //
        private int _x;
        public int x { get { return _x; } }
        //
        private int _y;
        public int y { get { return _x; } }

        //
        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        //
        public Coordinate()
        {
            _x = 0;
            _y = 0;
        }

    }
}
