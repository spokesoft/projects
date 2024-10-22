namespace Tix.Build.Configuration;

public class SolutionConfig
{
    public string SolutionRoot { get; set; } = "c:/spokesoft/projects";
    public string SolutionName { get; set; } = "Tix";
    public string SolutionPath => Path.Combine(SolutionRoot, $"{SolutionName}.sln");
    public string SourceDir { get; set; } = "src";
    public string SourcePath => Path.Combine(SolutionRoot, SourceDir);

    public ProjectConfig Client => new() 
    { 
        ProjectName = "Tix.Client",
        ProjectRoot = Path.Combine(SourcePath, "Tix.Client"), 
    };

    public ProjectConfig Common => new() 
    { 
        ProjectName = "Tix.Common",
        ProjectRoot = Path.Combine(SourcePath, "Tix.Common"),
    };

    public ProjectConfig Console => new() 
    { 
        ProjectName = "Tix.Console",
        ProjectRoot = Path.Combine(SourcePath, "Tix.Console"),
    };

    public ProjectConfig Data => new() 
    { 
        ProjectName = "Tix.Data",
        ProjectRoot = Path.Combine(SourcePath, "Tix.Data"),
    };

    public ProjectConfig Database => new() 
    { 
        ProjectName = "Tix.Database",
        ProjectRoot = Path.Combine(SourcePath, "Tix.Database"),
    };

    public ProjectConfig Docs => new() 
    { 
        ProjectName = "Tix.Docs",
        ProjectRoot = Path.Combine(SourcePath, "Tix.Docs"),
    };

    public ProjectConfig Rest => new() 
    { 
        ProjectName = "Tix.Rest",
        ProjectRoot = Path.Combine(SourcePath, "Tix.Rest"),
    };

    public ProjectConfig Web => new() 
    { 
        ProjectName = "Tix.Web",
        ProjectRoot = Path.Combine(SourcePath, "Tix.Web"),
    };
}