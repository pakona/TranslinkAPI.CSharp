using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TranslinkAPI.CSharp
{
    [DataContract]
    public class RouteMap
    {
        /// <summary>
        /// The location of the route map file in KMZ format.
        /// </summary>
        [DataMember]
        public string Href;
    }
}
