using System;
using System.Collections.Generic;
using System.Text;

namespace Simulator
{
    interface IMapCell
    {
        public enum CellType
        {
            LaneSegment,
            Source,
            Sink,
            Controller,
            Intersection
        }

        /// <summary>
        /// Location of this cell, using the ICoordinate interface
        /// </summary>
        public ICoordinate Location { get; set; }

        /// <summary>
        /// Type of this cell
        /// </summary>
        public CellType Type { get; set; }

        /// <summary>
        /// a queue of vehicles going through this cell
        /// </summary>
        public Queue<IVehicle> Vehicles { get; set; }

        /// <summary>
        /// List of cell constraints, e.g. capacity, speed limit, etc. 
        /// </summary>
        public List<IConstraint> Constrains { get; set; }

        /// <summary>
        /// default behavior of this cell 
        /// </summary>
        /// <returns></returns>
        public bool Process();
    }
}
