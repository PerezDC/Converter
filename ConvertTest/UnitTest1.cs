using Microsoft.VisualStudio.TestTools.UnitTesting;
using Convert;
using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using System;

namespace ConvertTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_100kph()
        {
            double precision = .001;
            double expected = 62.1504;
            double actual = Convert.Converter.KmphToMph(100.0);

            Assert.IsTrue(Math.Abs(expected - actual) < precision);


        }

        [TestMethod]
        public void TestMethod_60mph()
        {
            Assert.AreEqual(96.53999999999999, Convert.Converter.MphToKmph(60.0));
        }
    }
}
