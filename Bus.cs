using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TranslinkAPI.CSharp
{
    /// <summary>
    /// The element containing the bus information.
    /// </summary>
    [DataContract]
    public class Bus
    {
        /// <summary>
        /// The vehicle number of the bus.
        /// </summary>
        [DataMember]
        public int VehicleNo;

        /// <summary>
        /// The id of the trip the bus currently running.
        /// </summary>
        [DataMember]
        public int TripId;

        /// <summary>
        /// The route number of the vehicle.
        /// </summary>
        [DataMember]
        public int RouteNo;

        /// <summary>
        /// The direction of the trip.
        /// </summary>
        [DataMember]
        public string Direction;

        /// <summary>
        /// The pattern of the trip.
        /// </summary>
        [DataMember]
        public string Pattern;

        /// <summary>
        /// The latitude of the vehicle location.
        /// </summary>
        [DataMember]
        public double Latitude;

        /// <summary>
        /// The longitude of the vehicle location.
        /// </summary>
        [DataMember]
        public double Longitude;

        /// <summary>
        /// The recorded time of the last location of the vehicle.
        /// </summary>
        [DataMember]
        public string RecordedTime;

        /// <summary>
        /// The element containing the route map information.
        /// </summary>
        [DataMember]
        public RouteMap RouteMap;
    }
}
