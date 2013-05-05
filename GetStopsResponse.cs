using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslinkAPI.CSharp
{
    public class GetStopsResponse : GetResponseBase
    {
        public GetStopsResponse()
        {
            Stops = new List<Stop>();
        }

        /// <summary>
        /// The element containing the next stops.
        /// </summary>
        public List<Stop> Stops { get; set; }

        public GetStopsStatus Status;
    }

    public enum GetStopsStatus
    {
        Valid = 0,
        InvalidApiKey = 10001,
        DatabaseConnectionError = 10002,
        InvalidStopNumber = 1001,
        StopNumberNotFound = 1002,
        UnknownStopCheckError = 1003,
        UnknownGetStopError = 1004,
        InvalidLatitudeOrLongitude = 1011,
        NoStopsFound = 1012,
        UnknownGetStopsError = 1013,
        RadiusTooLarge = 1014,
        InvalidRouteNumber = 1015
    }
}
