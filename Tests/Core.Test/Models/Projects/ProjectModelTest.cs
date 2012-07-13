using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrockSolutions.Ticker.Core.Models.Projects;
using BrockSolutions.Ticker.Core.Models.Tasks;

namespace BrockSolutions.Ticker.Core.Test.Models.ProjectModels
{
    [TestClass]
    public class ProjectModelModelTest
    {
        /// <summary>
        /// Test construction of ProjectModel object
        /// - After construction, object should not be null
        /// </summary>
        [TestMethod]
        public void TestConstructProjectModelNotNull()
        {
            var p = new ProjectModel();
            Assert.IsNotNull(p);
        }

        /// <summary>
        /// Test construction of ProjectModel object
        /// - After construction, object should be of type "ProjectModel"
        /// </summary>
        [TestMethod]
        public void TestConstructProjectModelTypeOfProjectModel()
        {
            var p = new ProjectModel();
            Assert.IsInstanceOfType(p, typeof(ProjectModel));
        }

        /// <summary>
        /// Test construction of ProjectModel object
        /// - After construction, object's name property should be null
        /// </summary>
        [TestMethod]
        public void TestConstructProjectModelNullName()
        {
            var p = new ProjectModel();
            Assert.IsNull(p.Name);
        }

        /// <summary>
        /// Test construction of ProjectModel object
        /// - After construction, object's TaskModels property should be null
        /// </summary>
        [TestMethod]
        public void TestConstructProjectModelNullTaskModels()
        {
            var p = new ProjectModel();
            Assert.IsNull(p.TaskModels);
        }

        /// <summary>
        /// Test construction of ProjectModel object
        /// - After construction, object's id property should be null
        /// </summary>
        [TestMethod]
        public void TestConstructProjectModelNullId()
        {
            var p = new ProjectModel();
            Assert.IsNull(p.Id);
        }

        /// <summary>
        /// Test construction of ProjectModel object
        /// - After construction, object's id property should not have a value
        /// </summary>
        [TestMethod]
        public void TestConstructProjectModelIdNotHasValue()
        {
            var p = new ProjectModel();
            Assert.IsFalse(p.Id.HasValue);
        }

        /// <summary>
        /// Test construction of ProjectModel object
        /// - After construction, object's id.value property should raise an InvalidOperationException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestConstructProjectModelIdValueRaises()
        {
            var p = new ProjectModel();
            var id = p.Id.Value;
        }

        /// <summary>
        /// Test ProjectModel object
        /// - When name property is null, tostring method should return base tostring representation
        /// </summary>
        [TestMethod]
        public void TestProjectModelToStringWithNullName()
        {
            var p = new ProjectModel();
            p.Name = null;

            Assert.AreEqual(p.ToString(), "BrockSolutions.Ticker.Core.Models.Projects.ProjectModel"); //Default representation from base object
        }

        /// <summary>
        /// Test ProjectModel object
        /// - When name property is empty, tostring method should return base tostring representation
        /// </summary>
        [TestMethod]
        public void TestProjectModelToStringWithEmptyName()
        {
            var p = new ProjectModel();
            p.Name = string.Empty;

            Assert.AreEqual(p.ToString(), "BrockSolutions.Ticker.Core.Models.Projects.ProjectModel"); //Default representation from base object
        }

        /// <summary>
        /// Test ProjectModel object
        /// - When name property is valid, tostring method should return name
        /// </summary>
        [TestMethod]
        public void TestProjectModelToStringWithName()
        {
            var name = "Test Name";
            var p = new ProjectModel() { Name = name };

            Assert.AreEqual(p.ToString(), name);
        }

        /// <summary>
        /// Test ProjectModel object
        /// - ProjectModel name property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestProjectModelSetName()
        {
            var name = "Test Name";
            var p = new ProjectModel() { Name = name };

            Assert.AreEqual(p.Name, name);
        }

        /// <summary>
        /// Test ProjectModel object
        /// - ProjectModel id property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestProjectModelSetIdPositive()
        {
            long id = 1;
            var p = new ProjectModel() { Id = id };

            Assert.AreEqual(p.Id, id);
        }

        /// <summary>
        /// Test ProjectModel object
        /// - ProjectModel id property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestProjectModelSetIdNegative()
        {
            long id = -1;
            var p = new ProjectModel() { Id = id };

            Assert.AreEqual(p.Id, id);
        }

        /// <summary>
        /// Test ProjectModel object
        /// - ProjectModel id property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestProjectModelSetIdZero()
        {
            long id = -1;
            var p = new ProjectModel() { Id = id };

            Assert.AreEqual(p.Id, id);
        }

        /// <summary>
        /// Test ProjectModel object
        /// - ProjectModel TaskModel property should have the same count as the list you set it to when it's empty
        /// </summary>
        [TestMethod]
        public void TestProjectModelSetTaskModelsEmpty()
        {
            var TaskModels = new List<TaskModel>() { };
            var p = new ProjectModel() { TaskModels = TaskModels };

            Assert.AreEqual(p.TaskModels.Count(), TaskModels.Count);
        }

        /// <summary>
        /// Test ProjectModel object
        /// - ProjectModel TaskModel property should have the same count as the list you set it to when it's not empty
        /// </summary>
        [TestMethod]
        public void TestProjectModelSetTaskModelsNotEmpty()
        {
            var TaskModels = new List<TaskModel>() { new TaskModel(), new TaskModel() };
            var p = new ProjectModel() { TaskModels = TaskModels };

            Assert.AreEqual(p.TaskModels.Count(), TaskModels.Count);
        }

        /// <summary>
        /// Test ProjectModel object
        /// - ProjectModel TaskModel property should equal the list you set it to when it's empty
        /// </summary>
        [TestMethod]
        public void TestProjectModelSetTaskModelsEmptyEqual()
        {
            var TaskModels = new List<TaskModel>() { };
            var p = new ProjectModel() { TaskModels = TaskModels };

            Assert.AreEqual(p.TaskModels, TaskModels);
        }

        /// <summary>
        /// Test ProjectModel object
        /// - ProjectModel TaskModel property should equal the list you set it to when it's not empty
        /// </summary>
        [TestMethod]
        public void TestProjectModelSetTaskModelsNotEmptyEqual()
        {
            var TaskModels = new List<TaskModel>() { new TaskModel(), new TaskModel() };
            var p = new ProjectModel() { TaskModels = TaskModels };

            Assert.AreEqual(p.TaskModels, TaskModels);
        }
    }
}
