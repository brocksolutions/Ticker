using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrockSolutions.Ticker.Shared
{
    /// <summary>
    /// Project
    /// </summary>
    public class Project
    {
        #region Properties

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tasks
        /// </summary>
        public IEnumerable<Task> Tasks { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public Project()
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
