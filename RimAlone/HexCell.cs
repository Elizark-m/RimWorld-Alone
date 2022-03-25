using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimAlone
{
    class HexCell
    {
        private Coordinate _HexCellCoordinate;
        private Chunk _parentChunk;

        //
        public HexCell(Chunk parent)
        {
            this._parentChunk = parent;
            _HexCellCoordinate = new Coordinate();
        }

        //
        public HexCell(Chunk parent, int x, int y)
        {
            this._parentChunk = parent;
            _HexCellCoordinate = new Coordinate(x, y);
        }
    }
}
