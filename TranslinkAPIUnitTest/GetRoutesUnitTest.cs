using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TranslinkAPI.CSharp;

namespace TranslinkAPIUnitTest
{
    [TestClass]
    public class GetRoutesUnitTest
    {
        [TestMethod]
        public async Task GetRoutesWithValidParamsReturnsValidRoutes()
        {
            GetRoutesResponse rsp = await Translink.GetRoutes(APIKey.Valid, 51549);
            Assert.AreEqual(GetRoutesStatus.Valid, rsp.Status);
            Assert.IsNotNull(rsp.Routes);
        }
    }
}
