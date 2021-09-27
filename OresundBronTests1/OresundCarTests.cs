using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron.Tests
{
    [TestClass()]
    public class OresundCarTests
    {

        [TestMethod()]
        public void GetDiscount_ByMethodDiscountPrice_Return161()
        {
            var obj = new OresundCar(true);

            var actualValue = obj.DiscountPrice(410,0);

            Assert.AreEqual(161, actualValue);
        }

        /// <summary>
        /// The method VehicleType is returning string. The actualValue is "OresundCar".
        /// </summary>
        [TestMethod()]
        public void GetVehicleType_ByMethodVehicleType_ReturnStringOresundCar()
        {
            var obj = new OresundCar();

            var actualValue = obj.VehicleType();

            Assert.AreEqual("OresundCar", actualValue);
        }

        

    }
}