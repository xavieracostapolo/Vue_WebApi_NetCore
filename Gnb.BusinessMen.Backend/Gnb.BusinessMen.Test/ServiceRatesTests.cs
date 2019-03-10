using System;
using System.Collections.ObjectModel;
using Gnb.BusinessMen.Data;
using Gnb.BusinessMen.Model;
using Gnb.BusinessMen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Gnb.BusinessMen.Test
{
    /// <summary>
    /// Service rates tests.
    /// </summary>
    [TestClass]
    public class ServiceRatesTests
    {
        /// <summary>
        /// Gets all test.
        /// </summary>
        [TestMethod]
        public void GetAllTest()
        {
            var moqDaoRates = new Mock<IDaoRates>();

            moqDaoRates.Setup(r => r.GetAll()).Returns(new Collection<Rates>());

            ServiceRates serviceRates = new ServiceRates(moqDaoRates.Object);

            Assert.AreNotEqual(serviceRates.GetAll(), null);
        }
    }
}
