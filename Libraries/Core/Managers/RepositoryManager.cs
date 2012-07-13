using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrockSolutions.Ticker.Core.Models.Projects;
using BrockSolutions.Ticker.Core.Interfaces;
using System.Configuration;

namespace BrockSolutions.Ticker.Core.Managers
{
    /// <summary>
    /// Project Repository Manager
    /// </summary>
    public static class RepositoryManager
    {
        #region Properties

        /// <summary>
        /// Repositories
        /// </summary>
        private static Dictionary<string, object> Repositories { get; set; }

        #endregion

        /// <summary>
        /// Get Manager
        /// </summary>
        /// <returns>Manager</returns>
        public static IRepository<T> GetManager<T>()
        {
            if (RepositoryManager.Repositories == null)
            {
                RepositoryManager.Repositories = new Dictionary<string, object>();
            }

            var typeofString = typeof(T).ToString();

            if (RepositoryManager.Repositories.Keys.Contains(typeofString))
            {
                var r = RepositoryManager.Repositories[typeofString] as IRepository<T>;
                return r;
            }

            var typeString = ConfigurationManager.AppSettings[typeofString];
            var type = Type.GetType(typeString);

            var genericRepository = Activator.CreateInstance(type);
            var repository = genericRepository as IRepository<T>;

            RepositoryManager.Repositories.Add(typeofString, repository);

            return repository;
        }
    }
}
