using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TranslinkAPI.CSharp
{
    /// <summary>
    /// The element containing the status information
    /// </summary>
    [DataContract]
    public class Status
    {
        /// <summary>
        /// The name of the service ("Location" or "Schedule").
        /// </summary>
        [DataMember]
        public string Name;

        /// <summary>
        /// The status of the service ("Online" or "Offline").
        /// </summary>
        [DataMember]
        public string Value;
    }
}
