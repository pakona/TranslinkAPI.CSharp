using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TranslinkAPI.CSharp
{
    public static class Translink
    {
        const string API_URL = "http://api.translink.ca/RTTIAPI/V1/";

        static async Task<HttpWebResponse> GetResponse(string requestString)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(requestString);
            webRequest.Accept = "application/json";
            return (HttpWebResponse)await HttpExtensions.GetResponseAsync(webRequest).ConfigureAwait(false);
        }

        static T ParseResponse<T>(HttpWebResponse webResponse)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            return (T)ser.ReadObject(webResponse.GetResponseStream());
        }

        static string GetRawResponseData(HttpWebResponse webResponse)
        {
            using (StreamReader sr = new StreamReader(webResponse.GetResponseStream()))
            {
                return sr.ReadToEnd();
            }
        }

        /// <summary>
        /// Get details for a specified stop.
        /// </summary>
        /// <param name="apiKey">Your ApiKey received during registration.</param>
        /// <param name="stopNo">A five-digit stop number.</param>
        /// <returns>Element containing details of the stop.</returns>
        public async static Task<GetStopResponse> GetStop(string apiKey, int stopNo)
        {
            var requestString = String.Format("{0}stops/{1}?apiKey={2}", API_URL, stopNo, apiKey);
            var webResponse = await GetResponse(requestString);

            var data = new GetStopResponse();
            data.HttpStatus = webResponse.StatusCode;
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                data.Stop = ParseResponse<Stop>(webResponse);
                data.Status = GetStopsStatus.Valid;
            }
            else
            {
                data.Error = ParseResponse<ErrorResponse>(webResponse);
                data.Status = (GetStopsStatus)data.Error.Code;
            }
            return data;
        }
        
        /// <summary>
        /// Stops are locations where buses provide scheduled service.
        /// </summary>
        /// <param name="apiKey">Your ApiKey received during registration.</param>
        /// <param name="lat">The latitude of your search (must be combined with long).</param>
        /// <param name="lng">The longitude of your search (must be combined with lat).</param>
        /// <param name="radius">If present, will search a radius for stops (must be combined with lat and long). Default 500. Maximum 2000.</param>
        /// <param name="routeNo">If present, will search for stops specific to route.</param>
        /// <returns>Element containing a list of stops.</returns>
        public async static Task<GetStopsResponse> GetStops(string apiKey, double lat, double lng, int radius = 500, string routeNo = "")
        {
            var requestString = String.Format("{0}stops?lat={1:0.####}&long={2:0.####}&radius={3}&routeNo={4}&apiKey={5}", API_URL, lat, lng, radius, routeNo, apiKey);
            var webResponse = await GetResponse(requestString);

            var data = new GetStopsResponse();
            data.HttpStatus = webResponse.StatusCode;
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                data.Stops = ParseResponse<List<Stop>>(webResponse);
                data.Status = GetStopsStatus.Valid;
            }
            else
            {
                data.Error = ParseResponse<ErrorResponse>(webResponse);
                data.Status = (GetStopsStatus)data.Error.Code;
            }
            return data;
        }

        /// <summary>
        /// Gets the next bus estimates for a particular stop. Returns schedule data if estimates are not available.
        /// </summary>
        /// <param name="apiKey">Your ApiKey received during registration.</param>
        /// <param name="stopNo">A five-digit stop number.</param>
        /// <param name="routeNo">If present, will search for stops specific to route.</param>
        /// <param name="count">The number of buses to return. Default 6.</param>
        /// <param name="timeFrame">The search time frame in minutes. Default 1440.</param>
        /// <returns>Element containing a list of next buses.</returns>
        public async static Task<GetStopEstimatesResponse> GetStopEstimates(string apiKey, int stopNo, string routeNo = "", int count = 6, int timeFrame = 1440)
        {
            string requestString = String.Format("{0}stops/{1}/estimates?count={2}&routeNo={3}&timeFrame={4}&apikey={5}", API_URL, stopNo, count, routeNo, timeFrame, apiKey);
            var webResponse = await GetResponse(requestString);

            var data = new GetStopEstimatesResponse();
            data.HttpStatus = webResponse.StatusCode;
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                data.NextBuses = ParseResponse<List<NextBus>>(webResponse);
                data.Status = GetStopEstimatesStatus.Valid;
            }
            else
            {
                data.Error = ParseResponse<ErrorResponse>(webResponse);
                data.Status = (GetStopEstimatesStatus)data.Error.Code;
            }
            return data;
        }

        /// <summary>
        /// Retrieve information about the specified vehicle.
        /// </summary>
        /// <param name="apiKey">Your ApiKey received during registration.</param>
        /// <param name="busNo">A vehicle id.</param>
        /// <returns>Information about the specified vehicle.</returns>
        public async static Task<GetBusResponse> GetBus(string apiKey, int busNo)
        {
            string requestString = String.Format("{0}buses/{1}?apikey={2}", API_URL, busNo, apiKey);
            var webResponse = await GetResponse(requestString);

            var data = new GetBusResponse();
            data.HttpStatus = webResponse.StatusCode;
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                data.Bus = ParseResponse<Bus>(webResponse);
                data.Status = GetBusesStatus.Valid;
            }
            else
            {
                data.Error = ParseResponse<ErrorResponse>(webResponse);
                data.Status = (GetBusesStatus)data.Error.Code;
            }
            return data;
        }

        /// <summary>
        /// Use the buses request to retrieve vehicle information of all or a filtered set of buses.
        /// </summary>
        /// <param name="apiKey">Your ApiKey received during registration.</param>
        /// <param name="stopNo">If present, will search for buses for stop id specified.</param>
        /// <param name="routeNo">If present, will search for stops specific to route.</param>
        /// <returns>Element containing a list of buses information.</returns>
        public async static Task<GetBusesResponse> GetBuses(string apiKey, string routeNo = "", int stopNo = -1)
        {
            string requestString = String.Format("{0}buses?routeNo={1}&apikey={2}{3}", API_URL, routeNo, apiKey, stopNo > -1 ? String.Format("&stopNo={0}", stopNo) : String.Empty);
            var webResponse = await GetResponse(requestString);

            var data = new GetBusesResponse();
            data.HttpStatus = webResponse.StatusCode;
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                data.Buses = ParseResponse<List<Bus>>(webResponse);
                data.Status = GetBusesStatus.Valid;
            }
            else
            {
                data.Error = ParseResponse<ErrorResponse>(webResponse);
                data.Status = (GetBusesStatus)data.Error.Code;
            }
            return data;
        }

        /// <summary>
        /// Retrieve informations about the specified route.
        /// </summary>
        /// <param name="apiKey">Your ApiKey received during registration.</param>
        /// <param name="routeNo">A bus route number.</param>
        /// <returns>Element containing informations about a route.</returns>
        public async static Task<GetRouteResponse> GetRoute(string apiKey, int routeNo)
        {
            string requestString = String.Format("{0}routes/{1}?apikey={2}", API_URL, routeNo, apiKey);
            var webResponse = await GetResponse(requestString);

            var data = new GetRouteResponse();
            data.HttpStatus = webResponse.StatusCode;
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                data.Route = ParseResponse<Route>(webResponse);
                data.Status = GetRoutesStatus.Valid;
            }
            else
            {
                data.Error = ParseResponse<ErrorResponse>(webResponse);
                data.Status = (GetRoutesStatus)data.Error.Code;
            }
            return data;
        }

        /// <summary>
        /// Routes are a sequenced pattern of service.
        /// </summary>
        /// <param name="apiKey">Your ApiKey received during registration.</param>
        /// <param name="stopNo">If present, will search for routes passing through this stop.</param>
        /// <returns>Element containing a list of routes.</returns>
        public async static Task<GetRoutesResponse> GetRoutes(string apiKey, int stopNo)
        {
            string requestString = String.Format("{0}buses?stopNo={1}&apikey={2}", API_URL, stopNo, apiKey);
            var webResponse = await GetResponse(requestString);

            var data = new GetRoutesResponse();
            data.HttpStatus = webResponse.StatusCode;
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                data.Routes = ParseResponse<List<Route>>(webResponse);
                data.Status = GetRoutesStatus.Valid;
            }
            else
            {
                data.Error = ParseResponse<ErrorResponse>(webResponse);
                data.Status = (GetRoutesStatus)data.Error.Code;
            }
            return data;
        }

        public async static Task<GetServiceStatusResponse> GetServiceStatus(string apiKey)
        {
            string requestString = String.Format("{0}status/all?apikey={1}", API_URL, apiKey);
            var webResponse = await GetResponse(requestString);

            var data = new GetServiceStatusResponse();
            data.HttpStatus = webResponse.StatusCode;
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                data.Statuses = ParseResponse<List<Status>>(webResponse);
                data.Status = GetServiceStatusStatus.Valid;
            }
            else
            {
                data.Error = ParseResponse<ErrorResponse>(webResponse);
                data.Status = (GetServiceStatusStatus)data.Error.Code;
            }
            return data;
        }
    }
}
