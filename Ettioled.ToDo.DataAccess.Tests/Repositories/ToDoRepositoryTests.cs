using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ettioled.ToDo.DataAccess.Data;
using Ettioled.ToDo.DataAccess.Repositories;
using Ettioled.ToDo.DataAccess.Tests.Extensions;

namespace Ettioled.ToDo.DataAccess.Tests.Repositories
{
    [TestClass]
    public class ToDoRepositoryTests
    {
        private Mock<IDatabaseContext> _mockDb;
        private ToDoRepository _repository;
        private Mock<DbSet<ToDoRecord>> _mockDbSet;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockDb = new Mock<IDatabaseContext>();
            _mockDbSet = new Mock<DbSet<ToDoRecord>>();
        }

        [TestMethod]
        public void GetByIdAndUserId_OnCall_ShouldReturnObjectWithCorrectType()
        {
            // Arrange
            var ces = new List<ToDoRecord>(){
                new ToDoRecord { ToDoId = 1, Description = "test1", UserId = "mike"  },
                new ToDoRecord { ToDoId = 2, Description = "test2", UserId = "ros" }
            };
            _mockDbSet.SetSource(ces);
            _mockDb.SetupGet(c => c.ToDos).Returns(_mockDbSet.Object);

            _repository = new ToDoRepository(_mockDb.Object);

            // Act
            var result = _repository.GetByIdAndUserId(1, "mike");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ToDoRecord));
        }
    }
}
