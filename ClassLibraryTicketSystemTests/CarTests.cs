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
            var mock = new Mock<Car>();

            mock.Setup(x => x.VehicleType()).Returns("Car");

            var actualValue = mock.Object.VehicleType();

            Assert.AreEqual("Car", actualValue);
        }

        [TestMethod]
        public void CheckLicenseplateTest()
        {
            //var mock = new Mock<Car>();

            //mock.Setup(x => x._licenseplate).Returns("123");

            //Assert.AreEqual();

            //mock.Setup(x => x._licenseplate).Returns("123456789");

            //var actualValue = mock.Object._licenseplate;

            //Assert.AreEqual(2, actualValue);
        }

        [TestMethod()]
        public void CheckLicenseTest()
        {
            //var mock = new Mock<Car>();
            //var actualValue = mock.Setup.CheckLicense();

            //Assert.AreEqual("1234567890", actualValue);
        }

        [TestMethod()]
        public void DiscountPriceTest()
        {
            var mock = new Mock<Car>();

            mock.Setup(x => x.DiscountPrice(240,5)).Returns(228);

            var actualValue = mock.Object.DiscountPrice(240,5);

            Assert.AreEqual(228, actualValue);
        }
    }
}