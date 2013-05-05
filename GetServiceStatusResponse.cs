using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslinkAPI.CSharp
{
    public class GetServiceStatusResponse : GetResponseBase
    {
        /// <summary>
        /// The element containing the list of statuses.
        /// </summary>
        public List<Status> Statuses { get; set; }

        public GetServiceStatusStatus Status;
    }

    public enum GetServiceStatusStatus
    {
        Valid = 0,
        InvalidApiKey = 10001,
        DatabaseConectionError = 10002,
        InvalidServiceName = 5001
    }
}
