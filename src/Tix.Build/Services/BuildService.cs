using Tix.Build.Configuration;

namespace Tix.Build.Services;

/// <summary>
/// Build service implementation
/// </summary>
/// <param name="process"></param>
/// <param name="config"></param>

public class BuildService(
    IProcessService process, 
    SolutionConfig config) : IBuildService
{
    private readonly IProcessService _process = process;
    private readonly SolutionConfig _config = config;

    /// <summary>
    /// Cleans the solution
    /// </summary>
    /// <returns></returns>
    
    public async Task CleanSolution()
    {
        await _process.ExecuteAsync("dotnet", "clean", _config.SolutionPath);
    }

    /// <summary>
    /// Restores the solution
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>

    public async Task RestoreSolution()
    {
        await _process.ExecuteAsync("dotnet", "restore", _config.SolutionPath);
    }

    /// <summary>
    /// Builds the client project
    /// </summary>
    /// <returns></returns>

    public async Task BuildClientProject()
    {
        await _process.ExecuteAsync("npm", "build", _config.Client.ProjectRoot);
    }

    /// <summary>
    /// Builds the client project
    /// </summary>
    /// <returns></returns>

    public async Task BuildCommonProject()
    {
        await _process.ExecuteAsync("dotnet", "build", _config.Common.ProjectRoot);
    }

    /// <summary>
    /// Build the console project
    /// </summary>
    /// <returns></returns>
    public async Task BuildConsoleProject()
    {
        await _process.ExecuteAsync("dotnet", "build", _config.Console.ProjectRoot);
    }

    /// <summary>
    /// Build the data project
    /// </summary>
    /// <returns></returns>
    public async Task BuildDataProject()
    {
        await _process.ExecuteAsync("dotnet", "build", _config.Data.ProjectRoot);
    }

    /// <summary>
    /// Build the database project
    /// </summary>
    /// <returns></returns>
    public async Task BuildDatabaseProject()
    {
        await _process.ExecuteAsync("dotnet", "build", _config.Database.ProjectRoot);
    }
}