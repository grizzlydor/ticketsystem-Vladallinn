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
    [TestClass]
    public class VehicleTests
    {
        /// <summary>
        /// This test is checking exception. Should be not more than 7 characters. 
        /// </summary>
        [TestMethod()]
        public void GetLicenseplate_ByTheObject_ThrowArgumentException()
        {
            var mock = new Mock<Vehicle>();
            var machine = mock.Object;

            Assert.ThrowsException<ArgumentException>(() => machine.Licenseplate = "1234567890");
        }
    }
}