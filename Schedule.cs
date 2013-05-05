using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TranslinkAPI.CSharp
{
    /// <summary>
    /// The element containing the schedule information.
    /// </summary>
    [DataContract]
    public class Schedule
    {
        /// <summary>
        /// The pattern of the specific trip.
        /// </summary>
        [DataMember]
        public string Pattern;

        /// <summary>
        /// The destination of the trip.
        /// </summary>
        [DataMember]
        public string Destination;

        /// <summary>
        /// The expected departure time of the trip at the specific stop.
        /// </summary>
        [DataMember]
        public string ExpectedLeaveTime;

        /// <summary>
        /// The expected departure time in minutes.
        /// </summary>
        [DataMember]
        public string ExpectedCountdown;

        /// <summary>
        /// The status of the trip. * indicates scheduled time. - indicates delay. + indicates bus is running ahead of schedule.
        /// </summary>
        [DataMember]
        public string ScheduleStatus;

        /// <summary>
        /// Indicates if trip is cancelled.
        /// </summary>
        [DataMember]
        public bool CanceledTrip;

        /// <summary>
        /// Indicates if stop is cancelled.
        /// </summary>
        [DataMember]
        public bool CanceledStop;

        /// <summary>
        /// Indicates if trip is added.
        /// </summary>
        [DataMember]
        public bool AddedTrip;

        /// <summary>
        /// Indicates if stop is added.
        /// </summary>
        [DataMember]
        public bool AddedStop;

        /// <summary>
        /// The last updated time of the trip.
        /// </summary>
        [DataMember]
        public string LastUpdate;
    }
}
