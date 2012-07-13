using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrockSolutions.Ticker.Core.Interfaces
{
    /// <summary>
    /// Repository Interface
    /// </summary>
    public interface IRepository<T>
    {
        #region Methods

        /// <summary>
        /// Get All
        /// </summary>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get Single By Id
        /// </summary>
        T GetSingleById(long id);

        /// <summary>
        /// Update
        /// </summary>
        T Update(T obj);

        /// <summary>
        /// Insert
        /// </summary>
        T Insert(T obj);

        /// <summary>
        /// Delete
        /// </summary>
        void Delete(T obj);

        #endregion
    }
}
