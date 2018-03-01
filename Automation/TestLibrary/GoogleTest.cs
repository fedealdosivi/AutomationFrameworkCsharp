using System;
using framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class GoogleTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void TestSimple()
        {
            GoogleHome home = new GoogleHome()
                .Go();
        }

        [TestMethod]
        public void TestSearch()
        {
            GoogleResults google = new GoogleHome()
                .Go()
                .Search("hola")
                .SelectSettings();
        }

        [TestCleanup]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
