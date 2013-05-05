using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslinkAPI.CSharp
{
    public class GetRoutesResponse : GetResponseBase
    {
        public List<Route> Routes { get; set; }

        public GetRoutesStatus Status { get; set; }
    }

    public enum GetRoutesStatus
    {
        Valid = 0,
        InvalidApiKey = 10001,
        DatabaseConnectionError = 10002,
        RouteNumberNotFound = 4002,
        UnknownGetRouteError = 4003,
        InvalidRoutenumber = 4004,
        InvalidStopNumber = 4011,
        StopNumberNotFound = 4012,
        UnknownError = 4013,
        NoRoutesFound = 4014
    }
}
