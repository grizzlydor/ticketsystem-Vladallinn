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
        public void GetPrice_ByMethodPrice_Return240()
        {
            var obj = new Car();

            var actualValue = obj.Price();

            Assert.AreEqual(240.0, actualValue);
        }

        /// <summary>
        /// The method VehicleType is returning string. The actualValue is "Car".
        /// </summary>
        [TestMethod()]
        public void GetVehicleType_ByMethodVehicleType_ReturnStringCar()
        {
            var obj = new Car();

            var actualValue = obj.VehicleType();

            Assert.AreEqual("Car", actualValue);
        }

        /// <summary>
        /// Test which 
        /// </summary>
        [TestMethod()]
        public void GetDiscount_ByMethodDiscountPrice_Return228()
        {
            var obj = new Car(true);

            var actualValue = obj.DiscountPrice();

            Assert.AreEqual(228, actualValue);
        }
        /// <summary>
        /// The method is making discount for the weekend and also if you have special card you are getting discount. 
        /// </summary>
        [TestMethod()]
        public void GetWeekendDiscountPrice_ByMethodWeekendDiscount_Return182()
        {
            
            var obj = new Car(true);

            var actualValue = obj.WeekendDiscount();

            Assert.AreEqual(182.4, actualValue);
        }
    }
}