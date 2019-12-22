﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Serialization;

namespace SimplePNML
{
    /// <summary>
    /// Describes the graphics of an edge element
    /// </summary>
    [Equals]
    [XmlType]
    public class Edge : ICollectable, ILined
    {
        /// <summary>
        /// Gets or sets how to visualize the line
        /// </summary>
        [XmlElement("line")]
        public Line Line { get; set; }

        /// <summary>
        /// Gets or sets the points of the edge
        /// </summary>
        [NotNull]
        [XmlElement("position")]
        public List<Position> Positions { get; set; } = new List<Position>();

        /// <summary>
        /// Creates a new graphics description for an edge element
        /// </summary>
        public Edge() { }

        /// <summary>
        /// Collects all child elements of this edge recursively
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ICollectable> Collect()
        {
            return Collector.Create(this)
                .Collect(Positions)
                .Collect(Line)
                .Build();
        }
    }
}
