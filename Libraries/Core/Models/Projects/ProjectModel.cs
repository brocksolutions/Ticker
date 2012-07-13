using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrockSolutions.Ticker.Core.Models.Tasks;

namespace BrockSolutions.Ticker.Core.Models.Projects
{
    /// <summary>
    /// Project
    /// </summary>
    public class ProjectModel
    {
        #region Properties

        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tasks
        /// </summary>
        public IEnumerable<TaskModel> TaskModels { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectModel()
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// To String
        /// </summary>
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.Name))
            {
                return this.Name;
            }
            else
            {
                return base.ToString();
            }
        }

        #endregion
    }
}
