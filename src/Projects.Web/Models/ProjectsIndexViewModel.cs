using Projects.Data.Models;

namespace Projects.Web.Models;

public class ProjectsIndexViewModel : AppViewModel
{
    public IEnumerable<Project> Projects { get; set; } = [];
}