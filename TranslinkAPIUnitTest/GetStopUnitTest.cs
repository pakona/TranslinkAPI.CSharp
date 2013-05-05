using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslinkAPI.CSharp;
using System.Threading.Tasks;

namespace TranslinkAPIUnitTest
{
    [TestClass]
    public class GetStopUnitTest
    {
        [TestMethod]
        public async Task GetStopWithValidParamsReturnsValidStop()
        {
            const int stopNo = 51549;
            GetStopResponse rsp = await Translink.GetStop(APIKey.Valid, stopNo);
            Assert.AreEqual(GetStopsStatus.Valid, rsp.Status);
            Assert.IsNotNull(rsp.Stop);
            Assert.AreEqual(stopNo, rsp.Stop.StopNo);
        }
    }
}
