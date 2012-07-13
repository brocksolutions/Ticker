using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;

namespace BrockSolutions.Ticker.Core.Models.Tasks
{
    /// <summary>
    /// Task Type Configuration
    /// </summary>
    public class TaskTypeConfiguration : EntityTypeConfiguration<TaskModel>
    {
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskTypeConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).IsRequired();
        }

        #endregion
    }
}
