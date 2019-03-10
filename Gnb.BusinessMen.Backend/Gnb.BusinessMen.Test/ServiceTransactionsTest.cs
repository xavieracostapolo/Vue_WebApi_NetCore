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
    /// Service transactions test.
    /// </summary>
    [TestClass]
    public class ServiceTransactionsTest
    {
        /// <summary>
        /// Gets all test.
        /// </summary>
        [TestMethod]
        public void GetAllTest()
        {
            var moqDaoRates = new Mock<IDaoRates>();
            var moqDaoTransactions = new Mock<IDaoTransactions>();

            moqDaoTransactions.Setup(t => t.GetAll()).Returns(new Collection<Transactions>());

            ServiceTransactions serviceTransactions = new ServiceTransactions(moqDaoTransactions.Object, moqDaoRates.Object);

            Assert.AreNotEqual(serviceTransactions.GetAll(), null);
        }

        [TestMethod]
        public void GetSumTotalBySku()
        {
            string sku = "T2006";
            var moqDaoRates = new Mock<IDaoRates>();
            var moqDaoTransactions = new Mock<IDaoTransactions>();

            moqDaoTransactions.Setup(t => t.GetTotalBySku(sku)).Returns(new Collection<Transactions>());

            ServiceTransactions serviceTransactions = new ServiceTransactions(moqDaoTransactions.Object, moqDaoRates.Object);

            Assert.AreNotEqual(serviceTransactions.GetTotalBySku(sku), null);
        }
    }
}
