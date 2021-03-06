using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimAlone
{
    class Chunk
    {
        // the number of cells from the center of the chunk not including the center
        private const int _chunkCellsRadius = 7;
        public int Radius { get { return _chunkCellsRadius; } }
        
        // the number of cells icluded in the chunk
        private const int _chunkCellsCount = 170; 
        public int Count { get { return _chunkCellsCount; } }
        
        //
        private Coordinate _chunkCoordite;
        public Coordinate Coordinates { get { return _chunkCoordite; } }

        // array of including cells
        private HexCell[] _Cells = new HexCell[_chunkCellsCount];

        // 6 layer:
        // topLeft, topRight, centerLeft, centerRight, bottomLeft, bottomRight
        private HexCell[][] _RadiusCells = new HexCell[_chunkCellsCount][];
        

        public Chunk()
        {
            _chunkCoordite = new Coordinate();
        }
    }
}
