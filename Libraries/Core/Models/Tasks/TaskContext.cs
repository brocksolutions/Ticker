using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace BrockSolutions.Ticker.Core.Models.Tasks
{
    /// <summary>
    /// Task Context
    /// </summary>
    public class TaskContext : DbContext
    {
        #region Properties

        /// <summary>
        /// Tasks
        /// </summary>
        public DbSet<TaskModel> Tasks { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// On Model Creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TaskTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
