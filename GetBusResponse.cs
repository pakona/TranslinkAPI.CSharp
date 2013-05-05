using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslinkAPI.CSharp
{
    public class GetBusResponse : GetResponseBase
    {
        /// <summary>
        /// The element containing the bus information.
        /// </summary>
        public Bus Bus { get; set; }

        public GetBusesStatus Status;
    }
}
