using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void LogBackend_Read_Default_Should_Pass()
        {
            // Arrange
            var myTest = LogBackend.Instance;
            var myLog = new LogModel
            {
                ID = "1",
                PhoneID = "Phone"
            };

            // Act
            myTest.Create(myLog);
            var result = myTest.Read("1");

            // Assert
            Assert.AreEqual(myLog.ID, result.ID);

        }

        [TestMethod]
        public void LogBackend_Update_Default_Should_Pass()
        {
            // Arrange
            var myTest = LogBackend.Instance;
            var myLog = new LogModel
            {
                ID = "1",
                PhoneID = "Phone"
            };
            var myUpdate = new LogModel
            {
                ID = "1",
                PhoneID = "Phone2"
            };

            // Act
            myTest.Create(myLog);
            var result = myTest.Update(myUpdate);

            // Assert
            Assert.AreEqual(myUpdate.PhoneID, result.PhoneID);

        }

        [TestMethod]
        public void LogBackend_Delete_Default_Should_Pass()
        {
            // Arrange
            var myTest = LogBackend.Instance;
            var myLog = new LogModel
            {
                ID = "1",
                PhoneID = "Phone"
            };

            // Act
            myTest.Create(myLog);
            var result = myTest.Delete("1");

            // Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void LogBackend_Index_Default_Should_Pass()
        {
            // Arrange
            var myTest = LogBackend.Instance;

            // Act
            var result = myTest.Index();

            // Assert
            Assert.IsNotNull(result);

        }
    }
}
