using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslinkAPI.CSharp
{
    public class GetBusesResponse : GetResponseBase
    {
        /// <summary>
        /// The element containing the buses information.
        /// </summary>
        public List<Bus> Buses { get; set; }

        public GetBusesStatus Status;
    }

    public enum GetBusesStatus
    {
        Valid = 0,
        InvalidApiKey = 10001,
        DatabaseConnectionError = 10002,
        InvalidBusNumber = 2001,
        BurNumberNotFound = 2002,
        UnknownGetBusError = 2003,
        NoBusesFound = 2011,
        UnknownGetBusesByStopError = 2012,
        UnknownGetBusesByRouteError = 2013,
        InvalidStopNumber = 2014,
        InvalidRouteNumber = 2015,
        StopNumberNotFound = 2016,
        RouteNumberNotFound = 2017,
        UnknownGetBusesByStopAndRouteError = 2018
    }
}
