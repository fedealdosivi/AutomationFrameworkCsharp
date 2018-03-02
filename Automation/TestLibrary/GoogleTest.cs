﻿using System;
using framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class GoogleTest : WebTest
    {

        [TestMethod]
        public void TestSimple()
        {
            GoogleResults results = new GoogleHome()
                .Go()
                .Search("hola");

            Assert.IsTrue(results.VerifyResults());
        }

        [TestMethod]
        public void TestSettings()
        {
            GoogleResults google = new GoogleHome()
                .Go()
                .Search("hola")
                .SelectSettings();
        }

        [TestMethod]
        public void TestImages()
        {
            GoogleImages google = new GoogleHome()
                .Go()
                .Search("HOLA")
                .SelectImages();
        }
    }
}
