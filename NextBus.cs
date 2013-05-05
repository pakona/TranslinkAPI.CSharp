using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TranslinkAPI.CSharp
{
    /// <summary>
    /// The element containing the next bus information.
    /// </summary>
    [DataContract]
    public class NextBus
    {
        /// <summary>
        /// The bus route number.
        /// </summary>
        [DataMember]
        public int RouteNo;

        /// <summary>
        /// The bus route name.
        /// </summary>
        [DataMember]
        public string RouteName;

        /// <summary>
        /// The direction of the route at the specific stop.
        /// </summary>
        [DataMember]
        public string Direction;

        /// <summary>
        /// The element containing the route map information.
        /// </summary>
        [DataMember]
        public RouteMap RouteMap;

        /// <summary>
        /// The element containing the schedules.
        /// </summary>
        [DataMember]
        public List<Schedule> Schedules;
    }
}
