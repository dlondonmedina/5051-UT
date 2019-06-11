using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ReportViewModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel {
                NumberOfUsers = 1
            };

            // Act
            

            // Assert
            Assert.AreEqual(1, myTest.NumberOfUsers);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel
            {
                NumberOfUsers = 1
            };

            // Act
            myTest.NumberOfUsers = 2;

            // Assert
            Assert.AreEqual(2, myTest.NumberOfUsers);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.LogViewModel;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();
            var myLogView = new LogViewModel();
            
            // Act
            myTest.LogViewModel = myLogView;
      
            // Assert
            Assert.AreEqual(myLogView, myTest.LogViewModel);
        }
    }
}
