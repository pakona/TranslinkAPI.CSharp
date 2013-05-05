using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TranslinkAPI.CSharp
{
    /// <summary>
    /// The element containing the stop information.
    /// </summary>
    [DataContract]
    public class Stop
    {
        /// <summary>
        /// The 5-digtal stop number.
        /// </summary>
        [DataMember]
        public int StopNo;

        /// <summary>
        /// The stop name.
        /// </summary>
        [DataMember]
        public string Name;

        /// <summary>
        /// The bay number, if applicable.
        /// </summary>
        [DataMember]
        public string BayNo;

        /// <summary>
        /// The city in which the stop is located.
        /// </summary>
        [DataMember]
        public string City;

        /// <summary>
        /// The street name the stop is located on.
        /// </summary>
        [DataMember]
        public string OnStreet;

        /// <summary>
        /// The intersecting street of the stop.
        /// </summary>
        [DataMember]
        public string AtStreet;

        /// <summary>
        /// The latitude of the stop.
        /// </summary>
        [DataMember]
        public double Latitude;

        /// <summary>
        /// The longitude of the stop.
        /// </summary>
        [DataMember]
        public double Longitude;

        /// <summary>
        /// Specifies wheelchair accessible stop. 1 indicates stop is wheelchair accessible.
        /// </summary>
        [DataMember]
        public bool WheelchairAccess;

        /// <summary>
        /// Distance away from the search location.
        /// </summary>
        [DataMember]
        public double Distance;

        /// <summary>
        /// The list of routes that the stop services.
        /// </summary>
        [DataMember]
        public String Routes;

        
    }
}
