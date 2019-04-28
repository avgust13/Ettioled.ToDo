using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ettioled.ToDo.Business.Data;
using Ettioled.ToDo.Business.Mapping;
using Ettioled.ToDo.Business.Services;
using Ettioled.ToDo.DataAccess;
using Ettioled.ToDo.DataAccess.Data;
using Ettioled.ToDo.DataAccess.Repositories;

namespace Ettioled.ToDo.Business.Tests.Services
{
    [TestClass]
    public class ToDoServiceTests
    {
        private Mock<IUnitOfWork> _mockUoW;
        private Mock<IToDoRepository> _mockRepository;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Mapper.Initialize(x => x.AddProfile<BusinessMappingProfile>());
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new Mock<IToDoRepository>();

            _mockUoW = new Mock<IUnitOfWork>();
            _mockUoW.SetupGet(u => u.ToDo).Returns(_mockRepository.Object);
        }


        [TestMethod]
        public void GetById_OnCall_ShouldReturnCorrectRecord()
        {
            // Arrange
            var ce = new ToDoRecord { ToDoId = 1, UserId = "mike", Description = "test" };

            _mockRepository.Setup(r => r.GetByIdAndUserId(1, "mike")).Returns(ce);
            var service = new ToDoService(_mockUoW.Object);

            // Act
            var result = service.GetById(1, "mike");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ToDoData));
        }

        [TestMethod]
        public void GetUserToDoList_OnCall_ShouldReturnMany()
        {
            // Arrange
            string userId = "mike";
            var ces = new List<ToDoRecord>(){
                new ToDoRecord { ToDoId = 1, UserId = "mike", Description = "test1",  },
                new ToDoRecord { ToDoId = 2, UserId = "mike", Description = "test2",  }
            };

            _mockRepository.Setup(r => r.GetAllByUserId(userId)).Returns(ces);
            var service = new ToDoService(_mockUoW.Object);

            // Act
            var result = service.GetUserToDoList(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue((result as List<ToDoData>).Count > 1);
        }
    }
}
