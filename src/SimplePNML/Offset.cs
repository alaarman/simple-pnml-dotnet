﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimplePNML
{
    /// <summary>
    /// Stores an offset in two dimensions
    /// </summary>
    [Equals]
    [XmlType]
    public class Offset : ICollectable
    {
        /// <summary>
        /// Gets or sets the offset in X direction
        /// </summary>
        [XmlAttribute("x")]
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the offset in Y direction
        /// </summary>
        [XmlAttribute("y")]
        public double Y { get; set; }

        /// <summary>
        /// Creates an empty offset
        /// </summary>
        public Offset() { }

        /// <summary>
        /// Creates a new offset
        /// </summary>
        /// <param name="x">The position in X direction</param>
        /// <param name="y">The position in Y direction</param>
        public Offset(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ICollectable> Collect()
        {
            yield return this;
        }
    }
}