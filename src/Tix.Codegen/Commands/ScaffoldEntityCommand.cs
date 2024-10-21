using System.CommandLine;
using Spokesoft.Tix.Services;
namespace Spokesoft.Tix.Codegen.Commands;

/// <summary>
/// Scaffold Entity Command
/// </summary>
public class ScaffoldEntityCommand : Command
{
    /// <summary>
    /// Scaffolding service
    /// </summary>
    public IScaffoldingService Scaffolding { get; set; }

    /// <summary>
    /// Schema option
    /// </summary>
    public Argument<string> TableArgument = new(
        name: "table",
        description: "The table to generate the entity from");

    /// <summary>
    /// Schema option
    /// </summary>
    public Option<string> SchemaOption = new(
        name: "--schema",
        description: "The schema of the table or view",
        getDefaultValue: () => "dbo");

    /// <summary>
    /// Scaffold Entity Command Constructor
    /// </summary>
    public ScaffoldEntityCommand(IScaffoldingService scaffolding) : base("entity", "Scaffold an entity") 
    {
        Scaffolding = scaffolding;
        AddArgument(TableArgument);
        AddOption(SchemaOption);
        this.SetHandler(Execute, TableArgument, SchemaOption);
    }

    /// <summary>
    /// Execute scaffold entity command
    /// </summary>
    public void Execute(string schema, string table)
    {
        Scaffolding.GenerateEntity(schema, table);
    }
}