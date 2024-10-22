using System.CommandLine;

namespace Tix.Build.Commands;

/// <summary>
/// Clean command
/// </summary>
public class CleanCommand : Command
{
    /// <summary>
    /// Constructor
    /// </summary>
    public CleanCommand() : base("clean", "Cleans a target project.")
    {
    }
}