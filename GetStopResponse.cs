using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranslinkAPI.CSharp
{
    public class GetStopResponse : GetResponseBase
    {
        public Stop Stop { get; set; }

        public GetStopsStatus Status;
    }
}
