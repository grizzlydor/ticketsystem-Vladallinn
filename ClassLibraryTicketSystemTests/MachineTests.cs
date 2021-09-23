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
    public class MachineTests
    {
        [TestMethod()]
        public void CheckLicenseTest()
        {
            var mock = new Mock<Machine>();
            var machine = mock.Object;

            Assert.ThrowsException<ArgumentException>(() => machine.Licenseplate = "1234567890");
        }
    }
}