using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;

namespace BrockSolutions.Ticker.Core.Models.Projects
{
    /// <summary>
    /// Project Type Configuration
    /// </summary>
    public class ProjectTypeConfiguration : EntityTypeConfiguration<ProjectModel>
    {
        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectTypeConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).IsRequired();
        }

        #endregion
    }
}
