using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator
{
    /// <summary>
    /// A Map grid is a set of MapCells
    /// </summary>
    class MapGrid
    {
        public IEnumerable<IMapCell> Cells { get; set; }
    }
}
