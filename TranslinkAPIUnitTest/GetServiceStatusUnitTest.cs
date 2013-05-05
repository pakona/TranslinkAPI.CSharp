using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TranslinkAPI.CSharp;
using System.Threading.Tasks;

namespace TranslinkAPIUnitTest
{
    [TestClass]
    public class GetServiceStatusUnitTest
    {
        [TestMethod]
        public async Task GetServiceStatusWithValidParamsReturnsValidStatus()
        {
            GetServiceStatusResponse rsp = await Translink.GetServiceStatus(APIKey.Valid);
            Assert.AreEqual(GetServiceStatusStatus.Valid, rsp.Status);
            Assert.AreEqual(2, rsp.Statuses.Count);
            Assert.AreEqual("Schedule", rsp.Statuses[0].Name);
            Assert.AreEqual("Location", rsp.Statuses[1].Name);
        }
    }
}
