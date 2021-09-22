using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

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
            var mock = new Mock<Car>()
            {
                CallBase = true
            };

            mock.Setup(x => x.Price()).Returns(240.0);

            var actualValue = mock.Object.Price();

            Assert.AreEqual(240.0, actualValue);
        }

        /// <summary>
        /// The method VehicleType is returning string. The actualValue is "Car".
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest()
        {
            var mock = new Mock<Car>()
            {
                CallBase = true
            };

            mock.Setup(x => x.VehicleType()).Returns("Car");

            var actualValue = mock.Object.VehicleType();

            Assert.AreEqual("Car", actualValue);
        }
    }
}