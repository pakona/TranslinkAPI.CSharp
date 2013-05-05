using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslinkAPI.CSharp;
using System.Threading.Tasks;

namespace TranslinkAPIUnitTest
{
    [TestClass]
    public class GetBusUnitTest
    {
        [TestMethod]
        public async Task GetBusWithValidParamsReturnsValidBus()
        {
            const int busNo = 9748;
            GetBusResponse rsp = await Translink.GetBus(APIKey.Valid, busNo);
            Assert.AreEqual(GetBusesStatus.Valid, rsp.Status);
            Assert.IsNotNull(rsp.Bus);
            Assert.AreEqual(busNo, rsp.Bus.VehicleNo);
        }

        [TestMethod]
        public async Task GetBusWithInValidIdReturnsInvalidBusError()
        {
            GetBusResponse rsp = await Translink.GetBus(APIKey.Valid, -1);
            Assert.AreEqual(GetBusesStatus.InvalidBusNumber, rsp.Status);
        }
    }
}
