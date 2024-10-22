using System.CommandLine;

namespace Tix.Build.Commands;

/// <summary>
/// Scaffold command
/// </summary>
public class ScaffoldCommand : Command
{
    /// <summary>
    /// Scaffold command constructor
    /// </summary>
    public ScaffoldCommand() : base("scaffold", "Scaffold a new project or file.")
    {
    }
}