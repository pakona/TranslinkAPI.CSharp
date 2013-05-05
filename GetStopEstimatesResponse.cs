using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslinkAPI.CSharp
{
    public class GetStopEstimatesResponse : GetResponseBase
    {
        public GetStopEstimatesResponse()
        {
            NextBuses = new List<NextBus>();
        }

        /// <summary>
        /// The element containing the next buses.
        /// </summary>
        public List<NextBus> NextBuses { get; set; }

        public GetStopEstimatesStatus Status;
    }

    public enum GetStopEstimatesStatus
    {
        Valid = 0,
        InvalidApiKey = 10001,
        DatabaseConnectionError = 10002,
        InvalidStopNumber = 3001,
        StopNumberNotFound = 3002,
        UnknownGetEstimatesError = 3003,
        InvalidRoute = 3004,
        NoStopEstimatesFound = 3005,
        InvalidTimeFrame = 3006,
        InvalidCount = 3007
    }
}
