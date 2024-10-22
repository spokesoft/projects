using System.CommandLine;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tix.Build.Commands;
using Tix.Build.Services;

namespace Tix.Build;

public class Program
{
    /// <summary>
    /// Executes the application.
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    
    public static async Task<int> Main(string[] args)
    {
        return await BuildRootCommand(BuildServiceProvider()).InvokeAsync(args);
    }

    /// <summary>
    /// Builds the configuration.
    /// </summary>
    /// <returns></returns>

    private static IConfigurationRoot BuildConfiguration()
    {
        return new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
    }

    /// <summary>
    /// Builds the service provider.
    /// </summary>
    /// <returns></returns>

    private static ServiceProvider BuildServiceProvider()
    {
        var services = new ServiceCollection();
        var config = BuildConfiguration();

        services.AddSingleton<IConfiguration>(config);
        services.AddSingleton<IProcessService, ProcessService>();
        services.AddSingleton<IBuildService, BuildService>();

        return services.BuildServiceProvider();
    }

    /// <summary>
    /// Builds the application command-line interface.
    /// </summary>
    /// <param name="provider"></param>
    /// <returns></returns>

    private static RootCommand BuildRootCommand(ServiceProvider provider)
    {
        var root = new RootCommand("Tix build tool")
        {
            provider.GetRequiredService<BuildCommand>(),
            provider.GetRequiredService<CleanCommand>(),
            provider.GetRequiredService<DeployCommand>(),
            provider.GetRequiredService<ScaffoldCommand>(),
            provider.GetRequiredService<WatchCommand>()
        };
        return root;
    }
}