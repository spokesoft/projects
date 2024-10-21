using System.CommandLine;
namespace Spokesoft.Tix.Codegen.Commands;

/// <summary>
/// Scaffold db context command
/// </summary>
public class ScaffoldDbContextCommand : Command
{
    /// <summary>
    /// Force option
    /// </summary>
    public Option<bool> ForceOption = new(
        name: "--force",
        description: "Overwrite existing files",
        getDefaultValue: () => false);
    
    /// <summary>
    /// Context dir option
    /// </summary>
    public Option<string> ContextDirOption = new(
        name: "--context-dir",
        description: "The directory to put files in",
        getDefaultValue: () => "./src/Tix.Data/Contexts");

    /// <summary>
    /// Entity dir option
    /// </summary>
    public Option<string> EntityDirOption = new(
        name: "--entity-dir",
        description: "The directory to put files in",
        getDefaultValue: () => "./src/Tix.Data/Entities");
    
    /// <summary>
    /// Entity dir option
    /// </summary>
    public Option<string> ConfigurationDirOption = new(
        name: "--configuration-dir",
        description: "The directory to put files in",
        getDefaultValue: () => "./src/Tix.Data/Configurations");
    
    /// <summary>
    /// Scaffold db context command constructor
    /// </summary>
    public ScaffoldDbContextCommand() : base("dbcontext", "Scaffold a db context") 
    {
        ForceOption.AddAlias("-f");

        AddOption(ForceOption);
        AddOption(ContextDirOption);
        AddOption(EntityDirOption);
        AddOption(ConfigurationDirOption);

        this.SetHandler((force) => {
            Console.WriteLine(force);
        }, ForceOption);
    }
}