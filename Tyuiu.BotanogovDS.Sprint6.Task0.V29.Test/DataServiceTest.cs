﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint6.Task0.V29.Lib;


namespace Tyuiu.BotanogovDS.Sprint6.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 0.722;
            Assert.AreEqual(wait, res);
        }
    }
}
