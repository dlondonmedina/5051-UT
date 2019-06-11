using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Backend;

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
    }
}
