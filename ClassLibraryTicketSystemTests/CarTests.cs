using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {

        /// <summary>
        /// The method Price is returning fixed price. The actualValue is 240.0.
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            var obj = new Car();

            var actualValue = obj.Price();

            Assert.AreEqual(240.0, actualValue);
        }

        /// <summary>
        /// The method VehicleType is returning string. The actualValue is "Car".
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest()
        {
            var obj = new Car();

            var actualValue = obj.VehicleType();

            Assert.AreEqual("Car", actualValue);
        }
    }
}