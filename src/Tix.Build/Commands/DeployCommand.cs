using System.CommandLine;

namespace Tix.Build.Commands;

/// <summary>
/// Deploy command
/// </summary>
public class DeployCommand : Command
{
    /// <summary>
    /// Constructor
    /// </summary>
    public DeployCommand() : base("clean", "Deploy a target project.")
    {
    }
}