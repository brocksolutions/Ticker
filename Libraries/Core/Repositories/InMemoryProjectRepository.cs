using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrockSolutions.Ticker.Core.Models.Projects;
using BrockSolutions.Ticker.Core.Interfaces;
using BrockSolutions.Ticker.Core.Models.Tasks;

namespace BrockSolutions.Ticker.Core.Repositories
{
    /// <summary>
    /// In Memory Project Repository
    /// </summary>
    public class InMemoryProjectRepository : IRepository<ProjectModel>
    {
        #region Properties

        /// <summary>
        /// Project Models
        /// </summary>
        private List<ProjectModel> ProjectModels { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public InMemoryProjectRepository()
        {
            this.ProjectModels = new List<ProjectModel>();
            
            //Sample Data
            this.ProjectModels.Add(new ProjectModel() { Id = 1, Name = "Test 1", TaskModels = new List<TaskModel>() { } });
            this.ProjectModels.Add(new ProjectModel() { Id = 2, Name = "Test 2", TaskModels = new List<TaskModel>() { } });
            this.ProjectModels.Add(new ProjectModel() { Id = 3, Name = "Test 3", TaskModels = new List<TaskModel>() { } });
            this.ProjectModels.Add(new ProjectModel() { Id = 4, Name = "Test 4", TaskModels = new List<TaskModel>() { } });
        }

        #endregion

        /// <summary>
        /// Get All
        /// </summary>
        public IEnumerable<ProjectModel> GetAll()
        {
            return this.ProjectModels;
        }

        /// <summary>
        /// Get Single By Id
        /// </summary>
        public ProjectModel GetSingleById(long id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update
        /// </summary>
        public ProjectModel Update(ProjectModel obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insert
        /// </summary>
        public ProjectModel Insert(ProjectModel obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete
        /// </summary>
        public void Delete(ProjectModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
