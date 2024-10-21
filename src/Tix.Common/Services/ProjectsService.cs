using Projects.Common.Interfaces;
using Projects.Data.Models;

namespace Projects.Common.Services;

public class ProjectsService : IProjectService
{
    public Project Search(string name, string description)
    {
        var project = new Project() {
            Name = name,
            Description = description
        };
        return project;
    }

    public Project Create(string name, string description)
    {
        var project = new Project() {
            Name = name,
            Description = description
        };
        return project;
    }

    public Project Update(Project project, string newName, string newDescription)
    {
        project.Name = newName;
        project.Description = newDescription;
        return project;
    }

    public Project Delete(Project project)
    {
        project.DeletedAt = DateTime.Now;
        return project;
    }
}