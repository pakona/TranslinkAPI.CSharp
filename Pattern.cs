using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TranslinkAPI.CSharp
{
    /// <summary>
    /// The element containing the pattern information.
    /// </summary>
    [DataContract]
    public class Pattern
    {
        /// <summary>
        /// The pattern number.
        /// </summary>
        [DataMember]
        public string PatternNo { get; set; }

        /// <summary>
        /// The destination of the pattern.
        /// </summary>
        [DataMember]
        public string Destination { get; set; }

        /// <summary>
        /// The element containing the route map information for the pattern.
        /// </summary>
        [DataMember]
        public RouteMap RouteMap { get; set; }

        /// <summary>
        /// The destination of the pattern.
        /// </summary>
        [DataMember]
        public string Direction { get; set; }
    }
}
