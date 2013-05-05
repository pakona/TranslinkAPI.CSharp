using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TranslinkAPI.CSharp
{
    public class GetResponseBase
    {
        public GetResponseBase()
        {
            HttpStatus = HttpStatusCode.OK;
            Error = new ErrorResponse();
        }

        public HttpStatusCode HttpStatus;
        public ErrorResponse Error { get; set; }
    }
}
