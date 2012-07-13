using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrockSolutions.Ticker.Core.Models.Projects;
using BrockSolutions.Ticker.Core.Interfaces;
using BrockSolutions.Ticker.Shared;
using BrockSolutions.Ticker.Core.Managers;

namespace BrockSolutions.Ticker.Manager
{
    /// <summary>
    /// Project Manager
    /// </summary>
    public static class ProjectManager
    {
        #region Properties

        /// <summary>
        /// Project Repository
        /// </summary>
        private static IRepository<ProjectModel> ProjectRepository
        {
            get
            {
                return RepositoryManager.GetManager<ProjectModel>();
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns>All projects</returns>
        public static IEnumerable<Project> GetAll()
        {
            var projects = new List<Project>();
            var projectModels = ProjectManager.ProjectRepository.GetAll();

            AutoMapper.Mapper.CreateMap<ProjectModel, Project>();

            foreach (var model in projectModels)
            {
                var project = AutoMapper.Mapper.Map<ProjectModel, Project>(model);
                projects.Add(project);
            }

            return projects;
        }

        #endregion
    }
}
