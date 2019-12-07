﻿using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SimplePNML
{
    /// <summary>
    /// Describes tool-specific data
    /// </summary>
    [Equals]
    [XmlType]
    public class ToolData : ICollectable
    {
        /// <summary>
        /// Gets or sets the name of the tool
        /// </summary>
        [XmlAttribute]
        public string Tool { get; set; }

        /// <summary>
        /// Gets or sets the version of the tool
        /// </summary>
        [XmlAttribute]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the XML elements describing the tool data
        /// </summary>
        [XmlAnyElement]
        public List<XElement> Content { get; set; } = new List<XElement>();

        /// <summary>
        /// Creates a new tool-specific data
        /// </summary>
        public ToolData() { }

        /// <summary>
        /// Creates a new tool-specific data
        /// </summary>
        /// <param name="tool">The tool name</param>
        /// <param name="version">The tool version</param>
        /// <param name="content">XML elements describing the tool-specific data</param>
        public ToolData(string tool, string version, params XElement[] content)
        {
            Tool = tool;
            Version = version;
            Content = content.ToList();
        }

        /// <summary>
        /// Sets the tool and the version, if defined
        /// </summary>
        /// <param name="tool">The tool name</param>
        /// <param name="version">An optional tool version</param>
        /// <returns>A reference to itself</returns>
        public ToolData ForTool(string tool, string version = null)
        {
            Tool = tool;
            Version = version;
            return this;
        }

        /// <summary>
        /// Sets the XML elements describing the tool-specific data
        /// </summary>
        /// <param name="content"></param>
        /// <returns>A reference to itself</returns>
        public ToolData WithContent(params XElement[] content)
        {
            Content = content.ToList();
            return this;
        }

        /// <summary>
        /// Sets the XML elements describing the tool-specific data via tuples
        /// </summary>
        /// <param name="content"></param>
        /// <returns>A reference to itself</returns>
        public ToolData WithContent(params (string, string)[] content)
        {
            Content = content.Select(element => new XElement(element.Item1, element.Item2)).ToList();
            return this;
        }

        public IEnumerable<ICollectable> Collect()
        {
            yield return this;
        }
    }
}
