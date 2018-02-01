using System;
using Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCity_has_Name()
        {
            var home = new NomadHome();
            c.GoTo();

            home.GoTo();
            NomadCity city = home.SelectCity(1);

            Assert.IsTrue(city.HasName(), "City has a name");
    }
}
