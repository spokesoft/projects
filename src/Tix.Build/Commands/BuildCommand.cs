using System.Collections.Concurrent;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Tix.Build.Commands;

/// <summary>
/// Build all command
/// </summary>
public class BuildCommand : Command
{
    /// <summary>
    /// Constructor
    /// </summary>
    public BuildCommand() : base("build", "Builds a target project.")
    {
        Add(new BuildAllCommand());
    }
}