using System;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ettioled.ToDo.Business.Services;
using Ettioled.ToDo.Web.Controllers.Api;
using System.Web.Http.Results;

namespace Ettioled.ToDo.Web.Tests.Controllers.Api
{
    [TestClass]
    public class ToDoControllerTests
    {
        private ToDoController _controller;
        private Mock<IToDoService> _mockService;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockService = new Mock<IToDoService>();

            _controller = new ToDoController(_mockService.Object);
        }

        [TestMethod]
        public void Delete_NoToDoWithGivenIdExists_ShouldReturnNotFound()
        {
            var result = _controller.Delete(1);

            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
