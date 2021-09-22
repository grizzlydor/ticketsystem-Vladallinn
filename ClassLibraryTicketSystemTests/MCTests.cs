using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass]
    public class MCTests
    {
        /// <summary>
        /// The method Price is returning fixed price. The actualValue is 125.0.
        /// </summary>
        [TestMethod]
        public void PriceTest()
        {
            var obj = new MC(true, 5, DateTime.Now, "Pro");

            var actualValue = obj.Price();

            Assert.AreEqual(125.0, actualValue);
        }

        /// <summary>
        /// The method VehicleType is returning string. The actualValue is "MC".
        /// </summary>
        [TestMethod]
        public void VehicleTypeTest()
        {
            var obj = new MC(true, 5, DateTime.Now, "Pro");

            var actualValue = obj.VehicleType();

            Assert.AreEqual("MC", actualValue);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void DiscountPriceTest()
        {
            var obj = new MC(true, 5, DateTime.Now, "Pro");

            var actualValue = obj.DiscountPrice(240,5);

            Assert.AreEqual(228, actualValue);
        }
    }
}