namespace Tix.Build.Configuration;

public class ProjectConfig
{
    public string ProjectRoot { get; set; }
    public string ProjectName { get; set; }
    public string ProjectPath => Path.Combine(ProjectRoot, ProjectName);
}