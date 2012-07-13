﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrockSolutions.Ticker.Shared.Test
{
    [TestClass]
    public class TaskTest
    {
        /// <summary>
        /// Test construction of Task object
        /// - After construction, object should not be null
        /// </summary>
        [TestMethod]
        public void TestConstructTaskNotNull()
        {
            var p = new Task();
            Assert.IsNotNull(p);
        }

        /// <summary>
        /// Test construction of Task object
        /// - After construction, object should be of type "Task"
        /// </summary>
        [TestMethod]
        public void TestConstructTaskTypeOfTask()
        {
            var p = new Task();
            Assert.IsInstanceOfType(p, typeof(Task));
        }

        /// <summary>
        /// Test construction of Task object
        /// - After construction, object's name property should be null
        /// </summary>
        [TestMethod]
        public void TestConstructTaskNullName()
        {
            var p = new Task();
            Assert.IsNull(p.Name);
        }

        /// <summary>
        /// Test Task object
        /// - When name property is null, tostring method should return base tostring representation
        /// </summary>
        [TestMethod]
        public void TestTaskToStringWithNullName()
        {
            var p = new Task();
            p.Name = null;

            Assert.AreEqual(p.ToString(), "BrockSolutions.Ticker.Shared.Task"); //Default representation from base object
        }

        /// <summary>
        /// Test Task object
        /// - When name property is empty, tostring method should return base tostring representation
        /// </summary>
        [TestMethod]
        public void TestTaskToStringWithEmptyName()
        {
            var p = new Task();
            p.Name = string.Empty;

            Assert.AreEqual(p.ToString(), "BrockSolutions.Ticker.Shared.Task"); //Default representation from base object
        }

        /// <summary>
        /// Test Task object
        /// - When name property is valid, tostring method should return name
        /// </summary>
        [TestMethod]
        public void TestTaskToStringWithName()
        {
            var name = "Test Name";
            var p = new Task() { Name = name };

            Assert.AreEqual(p.ToString(), name);
        }

        /// <summary>
        /// Test Task object
        /// - Task name property should equal what you set it to be
        /// </summary>
        [TestMethod]
        public void TestTaskSetName()
        {
            var name = "Test Name";
            var p = new Task() { Name = name };

            Assert.AreEqual(p.Name, name);
        }
    }
}
