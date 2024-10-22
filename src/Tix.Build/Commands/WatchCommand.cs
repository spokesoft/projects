using System.CommandLine;

namespace Tix.Build.Commands;

/// <summary>
/// Scaffold command
/// </summary>
public class WatchCommand : Command
{
    /// <summary>
    /// Scaffold command constructor
    /// </summary>
    public WatchCommand() : base("watch", "Watches for changes in a project and rebuilds it.")
    {
    }
}