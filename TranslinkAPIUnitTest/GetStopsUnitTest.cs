using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslinkAPI.CSharp;
using System.Threading.Tasks;

namespace TranslinkAPIUnitTest
{
    [TestClass]
    public class GetStopsUnitTest
    {
        [TestMethod]
        public async Task GetStopsWithValidParamsReturnsValidStops()
        {
            GetStopsResponse rsp = await Translink.GetStops(APIKey.Valid, 49.249312, -123.010354, 75);
            Assert.AreEqual(GetStopsStatus.Valid, rsp.Status);
            Assert.IsNotNull(rsp.Stops);
        }

        [TestMethod]
        public async Task GetStopsWithInvalidKeyReturnsInvalidKeyError()
        {
            GetStopsResponse rsp = await Translink.GetStops(APIKey.Invalid, 49.249312, -123.010354, 100);
            Assert.AreEqual(10001, rsp.Error.Code);
            Assert.AreEqual(GetStopsStatus.InvalidApiKey, rsp.Status);
        }
    }
}
