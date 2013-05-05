using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslinkAPI.CSharp
{
    public class GetRouteResponse : GetResponseBase
    {
        public Route Route { get; set; }

        public GetRoutesStatus Status { get; set; }
    }
}
