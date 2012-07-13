using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrockSolutions.Ticker.Core.Models.Tasks
{
    /// <summary>
    /// Task
    /// </summary>
    public class TaskModel
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

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskModel()
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
