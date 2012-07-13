using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrockSolutions.Ticker.Core.Models.Tasks;

namespace BrockSolutions.Ticker.Core.Test.Models.TaskModels
{
    [TestClass]
    public class TaskModelModelTest
    {
        /// <summary>
        /// Test construction of TaskModel object
        /// - After construction, object should not be null
        /// </summary>
        [TestMethod]
        public void TestConstructTaskModelNotNull()
        {
            var p = new TaskModel();
            Assert.IsNotNull(p);
        }

        /// <summary>
        /// Test construction of TaskModel object
        /// - After construction, object should be of type "TaskModel"
        /// </summary>
        [TestMethod]
        public void TestConstructTaskModelTypeOfTaskModel()
        {
            var p = new TaskModel();
            Assert.IsInstanceOfType(p, typeof(TaskModel));
        }

        /// <summary>
        /// Test construction of TaskModel object
        /// - After construction, object's name property should be null
        /// </summary>
        [TestMethod]
        public void TestConstructTaskModelNullName()
        {
            var p = new TaskModel();
            Assert.IsNull(p.Name);
        }

        /// <summary>
        /// Test construction of TaskModel object
        /// - After construction, object's id property should be null
        /// </summary>
        [TestMethod]
        public void TestConstructTaskModelNullId()
        {
            var p = new TaskModel();
            Assert.IsNull(p.Id);
        }

        /// <summary>
        /// Test construction of TaskModel object
        /// - After construction, object's id property should not have a value
        /// </summary>
        [TestMethod]
        public void TestConstructTaskModelIdNotHasValue()
        {
            var p = new TaskModel();
            Assert.IsFalse(p.Id.HasValue);
        }

        /// <summary>
        /// Test construction of TaskModel object
        /// - After construction, object's id.value property should raise an InvalidOperationException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestConstructTaskModelIdValueRaises()
        {
            var p = new TaskModel();
            var id = p.Id.Value;
        }

        /// <summary>
        /// Test TaskModel object
        /// - When name property is null, tostring method should return base tostring representation
        /// </summary>
        [TestMethod]
        public void TestTaskModelToStringWithNullName()
        {
            var p = new TaskModel();
            p.Name = null;

            Assert.AreEqual(p.ToString(), "BrockSolutions.Ticker.Core.Models.Tasks.TaskModel"); //Default representation from base object
        }

        /// <summary>
        /// Test TaskModel object
        /// - When name property is empty, tostring method should return base tostring representation
        /// </summary>
        [TestMethod]
        public void TestTaskModelToStringWithEmptyName()
        {
            var p = new TaskModel();
            p.Name = string.Empty;

            Assert.AreEqual(p.ToString(), "BrockSolutions.Ticker.Core.Models.Tasks.TaskModel"); //Default representation from base object
        }

        /// <summary>
        /// Test TaskModel object
        /// - When name property is valid, tostring method should return name
        /// </summary>
        [TestMethod]
        public void TestTaskModelToStringWithName()
        {
            var name = "Test Name";
            var p = new TaskModel() { Name = name };

            Assert.AreEqual(p.ToString(), name);
        }

        /// <summary>
        /// Test TaskModel object
        /// - TaskModel name property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestTaskModelSetName()
        {
            var name = "Test Name";
            var p = new TaskModel() { Name = name };

            Assert.AreEqual(p.Name, name);
        }

        /// <summary>
        /// Test TaskModel object
        /// - TaskModel id property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestTaskModelSetIdPositive()
        {
            long id = 1;
            var p = new TaskModel() { Id = id };

            Assert.AreEqual(p.Id, id);
        }

        /// <summary>
        /// Test TaskModel object
        /// - TaskModel id property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestTaskModelSetIdNegative()
        {
            long id = -1;
            var p = new TaskModel() { Id = id };

            Assert.AreEqual(p.Id, id);
        }

        /// <summary>
        /// Test TaskModel object
        /// - TaskModel id property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestTaskModelSetIdZero()
        {
            long id = -1;
            var p = new TaskModel() { Id = id };

            Assert.AreEqual(p.Id, id);
        }
    }
}
