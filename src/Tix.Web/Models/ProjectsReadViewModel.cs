using Projects.Data.Models;

namespace Projects.Web.Models;

public class ProjectsReadViewModel : AppViewModel
{
    public Project Project { get; set; } = null!;
}