using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TranslinkAPI.CSharp;

namespace TranslinkAPIUnitTest
{
    [TestClass]
    public class GetBusesUnitTest
    {
        [TestMethod]
        public async Task GetBusesWithValidParamsReturnsValidBuses()
        {
            GetBusesResponse rsp = await Translink.GetBuses(APIKey.Valid, "129");
            Assert.AreEqual(GetBusesStatus.Valid, rsp.Status);
            Assert.IsNotNull(rsp.Buses);
        }
    }
}
