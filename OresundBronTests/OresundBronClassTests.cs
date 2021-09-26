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
    public class OresundBronClassTests
    {
        [TestMethod()]
        public void GetPrice_ByMethodPrice_Return73()
        {
            var obj = new OresundBronClass();

            var actualValue = obj.GetPrice();

            Assert.AreEqual(73, actualValue);
        }
    }
}