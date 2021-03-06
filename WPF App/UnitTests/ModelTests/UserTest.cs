﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPF_App;

namespace UnitTests
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserInitializationTest()
        {
            User TestUser = new User();

            int expectedPoints = 0;
            int expectedAddingSpeed = 1;

            int currentPoints = TestUser.Points;
            int currentAddingSpeed = TestUser.SpeedOfAddingPoints;

            Assert.AreEqual(expectedPoints, currentPoints);
            Assert.AreEqual(expectedAddingSpeed, currentAddingSpeed);
        }
    }
}
