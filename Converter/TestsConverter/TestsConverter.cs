using Converter;
using Converter.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;
using System.Net;
using System.Text;

namespace TestsConverter
{
    [TestClass]
    public class TestsConverter
    {
        [TestMethod]
        public void Convert_Returns_FileContentResult()
        {
            // Arrange
            var validator = new Mock<IValidator>();
            FileContentResult file = new FileContentResult(Encoding.UTF8.GetBytes("test.txt"), "text/plain");
            validator.Setup(x => x.GetTempFile(20, FileType.Zip)).Returns(file);
            
            var controller = new ConverterController(validator.Object);

            var valid = new ValidationTemp
            {
                TempC = 20,
                FileType = FileType.Zip
            };

            // Act
            var result = controller.Convert(valid);

            // Assert
            Assert.IsInstanceOfType(result, typeof(FileContentResult));
        }

        [TestMethod]
        public void Index_Returns_ViewResult()
        {
            // Arrange
            var validator = new Mock<IValidator>();
            var controller = new ConverterController(validator.Object);

            var valid = new ValidationTemp();

            // Act
            var result = controller.Index(valid);
            var badRequestResult = result as ViewResult;

            // Assert
            Assert.IsNotNull(badRequestResult);
            validator.Verify(controller => controller.GetTempFahrenheit(It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        public void Index_Returns_NotValidModel_StatusCode400()
        {
            // Arrange
            var validator = new Mock<IValidator>();
            var controller = new ConverterController(validator.Object);
            controller.ModelState.AddModelError("key", "error message");

            var valid = new ValidationTemp
            {
                TempC = -300,
            };

            // Act
            var result = controller.Index(valid);
            var okResult = result as StatusCodeResult;

            // Assert
            Assert.IsInstanceOfType(okResult, typeof(BadRequestResult));
        }
    }
}
