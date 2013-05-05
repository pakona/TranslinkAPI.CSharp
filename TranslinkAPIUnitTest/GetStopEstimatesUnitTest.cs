using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslinkAPI.CSharp;
using System.Threading.Tasks;

namespace TranslinkAPIUnitTest
{
    [TestClass]
    public class GetStopEstimatesUnitTest
    {
        [TestMethod]
        public async Task GetStopEstimatesWithValidParamsReturnsValidEstimates()
        {
            GetStopEstimatesResponse rsp = await Translink.GetStopEstimates(APIKey.Valid, 51549);
            Assert.AreEqual(GetStopEstimatesStatus.Valid, rsp.Status);
            Assert.IsNotNull(rsp.NextBuses);
        }
    }
}
