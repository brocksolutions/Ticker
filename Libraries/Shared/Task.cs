using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrockSolutions.Ticker.Shared
{
    /// <summary>
    /// Task
    /// </summary>
    public class Task
    {
        #region Properties

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public Task()
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
