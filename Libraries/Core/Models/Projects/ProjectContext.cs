using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace BrockSolutions.Ticker.Core.Models.Projects
{
    /// <summary>
    /// Project Context
    /// </summary>
    public class ProjectContext : DbContext
    {
        #region Properties

        /// <summary>
        /// Projects
        /// </summary>
        public DbSet<ProjectModel> Projects { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// On Model Creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectTypeConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
