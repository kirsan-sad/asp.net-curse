using Converter;
using Converter.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;

namespace TestsConverter
{
    [TestClass]
    public class TestsConverter
    {
        [TestMethod]
        public void Convert_Returns_FileContentResult()
        {
            // Arrange
            var controller = new ConverterController();
            var valid = new ValidationTemp
            {
                TempC = 20,
                Output = Helper.Output.Zip
            };

            // Act
            var result = controller.Convert(valid);

            // Assert
            Assert.IsInstanceOfType(result, typeof(FileContentResult));
        }

    }
}
