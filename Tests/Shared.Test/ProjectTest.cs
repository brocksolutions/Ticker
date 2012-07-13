using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrockSolutions.Ticker.Shared.Test
{
    [TestClass]
    public class ProjectTest
    {
        /// <summary>
        /// Test construction of project object
        /// - After construction, object should not be null
        /// </summary>
        [TestMethod]
        public void TestConstructProjectNotNull()
        {
            var p = new Project();
            Assert.IsNotNull(p);
        }

        /// <summary>
        /// Test construction of project object
        /// - After construction, object should be of type "Project"
        /// </summary>
        [TestMethod]
        public void TestConstructProjectTypeOfProject()
        {
            var p = new Project();
            Assert.IsInstanceOfType(p, typeof(Project));
        }

        /// <summary>
        /// Test construction of project object
        /// - After construction, object's name property should be null
        /// </summary>
        [TestMethod]
        public void TestConstructProjectNullName()
        {
            var p = new Project();
            Assert.IsNull(p.Name);
        }

        /// <summary>
        /// Test construction of project object
        /// - After construction, object's tasks property should be null
        /// </summary>
        [TestMethod]
        public void TestConstructProjectNullTasks()
        {
            var p = new Project();
            Assert.IsNull(p.Tasks);
        }

        /// <summary>
        /// Test project object
        /// - When name property is null, tostring method should return base tostring representation
        /// </summary>
        [TestMethod]
        public void TestProjectToStringWithNullName()
        {
            var p = new Project();
            p.Name = null;

            Assert.AreEqual(p.ToString(), "BrockSolutions.Ticker.Shared.Project"); //Default representation from base object
        }

        /// <summary>
        /// Test project object
        /// - When name property is empty, tostring method should return base tostring representation
        /// </summary>
        [TestMethod]
        public void TestProjectToStringWithEmptyName()
        {
            var p = new Project();
            p.Name = string.Empty;

            Assert.AreEqual(p.ToString(), "BrockSolutions.Ticker.Shared.Project"); //Default representation from base object
        }

        /// <summary>
        /// Test project object
        /// - When name property is valid, tostring method should return name
        /// </summary>
        [TestMethod]
        public void TestProjectToStringWithName()
        {
            var name = "Test Name";
            var p = new Project() { Name = name };

            Assert.AreEqual(p.ToString(), name);
        }

        /// <summary>
        /// Test project object
        /// - Project name property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestProjectSetName()
        {
            var name = "Test Name";
            var p = new Project() { Name = name };

            Assert.AreEqual(p.Name, name);
        }

        /// <summary>
        /// Test project object
        /// - Project task property should have the same count as the list you set it to when it's empty
        /// </summary>
        [TestMethod]
        public void TestProjectSetTasksEmpty()
        {
            var tasks = new List<Task>() { };
            var p = new Project() { Tasks = tasks };

            Assert.AreEqual(p.Tasks.Count(), tasks.Count);
        }

        /// <summary>
        /// Test project object
        /// - Project task property should have the same count as the list you set it to when it's not empty
        /// </summary>
        [TestMethod]
        public void TestProjectSetTasksNotEmpty()
        {
            var tasks = new List<Task>() { new Task(), new Task() };
            var p = new Project() { Tasks = tasks };

            Assert.AreEqual(p.Tasks.Count(), tasks.Count);
        }

        /// <summary>
        /// Test project object
        /// - Project task property should equal the list you set it to when it's empty
        /// </summary>
        [TestMethod]
        public void TestProjectSetTasksEmptyEqual()
        {
            var tasks = new List<Task>() { };
            var p = new Project() { Tasks = tasks };

            Assert.AreEqual(p.Tasks, tasks);
        }

        /// <summary>
        /// Test project object
        /// - Project task property should equal the list you set it to when it's not empty
        /// </summary>
        [TestMethod]
        public void TestProjectSetTasksNotEmptyEqual()
        {
            var tasks = new List<Task>() { new Task(), new Task() };
            var p = new Project() { Tasks = tasks };

            Assert.AreEqual(p.Tasks, tasks);
        }
    }
}
