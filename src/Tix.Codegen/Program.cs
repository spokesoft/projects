using System.CommandLine;
using Microsoft.Extensions.DependencyInjection;
using Spokesoft.Tix.Codegen.Commands;
using Spokesoft.Tix.Services;

namespace Spokesoft.Tix.Codegen;

public class Program
{
    static async Task<int> Main(string[] args)
    {
        var services = ConfigureServices(new ServiceCollection());
        var provider = services.BuildServiceProvider();
        var codegen = provider.GetRequiredService<CodegenCommand>();
        return await codegen.InvokeAsync(args);
    }

    private static IServiceCollection ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IScaffoldingService, ScaffoldingService>();
        services.AddSingleton<CodegenCommand>();
        services.AddSingleton<ScaffoldCommand>();
        services.AddTransient<ScaffoldEntityCommand>();
        services.AddTransient<ScaffoldDbContextCommand>();
        return services;
    }
}
