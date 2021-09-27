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
    public class OresundMcTests
    {
        /// <summary>
        /// The method VehicleType is returning string. The actualValue is "OresundMc".
        /// </summary>
        [TestMethod()]
        public void GetVehicleType_ByMethodVehicleType_ReturnStringOresundMc()
        {
            var obj = new OresundMc();

            var actualValue = obj.VehicleType();

            Assert.AreEqual("OresundMc", actualValue);
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        public void GetDiscount_ByMethodDiscountPrice_Return71()
        {
            var obj = new OresundMc(true);

            var actualValue = obj.DiscountPrice(210, 0);

            Assert.AreEqual(73, actualValue);
        }
    }
}