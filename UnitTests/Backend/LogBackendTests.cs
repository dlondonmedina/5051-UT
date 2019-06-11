using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Backend;
using HW1c.Models;

namespace UnitTests.Backend
{
    [TestClass]
    public class LogBackendTests
    {
        [TestMethod]
        public void LogBackend_Instantiate_Default_Should_Pass()
        {
            // Arrange
            var myTest = LogBackend.Instance;
            // Act

            // Assert
            Assert.IsNotNull(myTest);

        }

        [TestMethod]
        public void LogBackend_Create_Default_Should_Pass()
        {
            // Arrange
            var myTest = LogBackend.Instance;
            var myLog = new LogModel
            {
                PhoneID = "Phone"
            };

            // Act
            var result = myTest.Create(myLog);

            // Assert
            Assert.AreEqual(myLog.PhoneID, result.PhoneID);

        }
    }
}
