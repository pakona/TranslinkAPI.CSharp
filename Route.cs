using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TranslinkAPI.CSharp
{
    [DataContract]
    public class Route
    {
        /// <summary>
        /// The bus route number.
        /// </summary>
        [DataMember]
        public int RouteNo { get; set; }

        /// <summary>
        /// The name of the route.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// The operating company of the route.
        /// </summary>
        [DataMember]
        public string OperatingCompany { get; set; }

        /// <summary>
        /// The list of patterns for the route.
        /// </summary>
        [DataMember]
        public List<Pattern> Patterns { get; set; }
    }
}
