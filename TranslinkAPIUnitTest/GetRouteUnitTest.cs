using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslinkAPI.CSharp;
using System.Threading.Tasks;

namespace TranslinkAPIUnitTest
{
    [TestClass]
    public class GetRouteUnitTest
    {
        [TestMethod]
        public async Task GetRouteWithValidParamsReturnsValidRoute()
        {
            const int routeNo = 129;
            GetRouteResponse rsp = await Translink.GetRoute(APIKey.Valid, routeNo);
            Assert.AreEqual(GetRoutesStatus.Valid, rsp.Status);
            Assert.IsNotNull(rsp.Route);
            Assert.AreEqual(routeNo, rsp.Route.RouteNo);
        }
    }
}
