using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Sodexo.Demo.Web.Controllers;

namespace Sodexo.Demo.Tests
{
    public class HomeControllerTests
    {
        private readonly Mock<ILogger<HomeController>> _mockLogger;
        private readonly HomeController _controller;

        public HomeControllerTests()
        {
            _mockLogger = new Mock<ILogger<HomeController>>();
            _controller = new HomeController(_mockLogger.Object);
        }

        [Fact]
        public void Index_Returns_ViewResult()
        {
            // Act
            var result = _controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Privacy_Returns_ViewResult()
        {
            // Act
            var result = _controller.Privacy();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Contacto_Returns_ViewResult()
        {
            // Act
            var result = _controller.Contacto();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Error_Returns_ViewResult_With_ErrorViewModel()
        {
            // Act
            var result = _controller.Error();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
