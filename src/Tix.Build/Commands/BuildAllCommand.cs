using System.Collections.Concurrent;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Tix.Build.Commands;

/// <summary>
/// Build all command
/// </summary>
public class BuildAllCommand : Command
{
    /// <summary>
    /// Constructor
    /// </summary>
    public BuildAllCommand() : base("all", "Builds all projects in the solution.")
    {
        Handler = new CommandHandler();
    }

    /// <summary>
    /// Command handler
    /// </summary>
    /// <param name="logger"></param>
    public class CommandHandler : ICommandHandler
    {
        //private readonly ILogger<CommandHandler> _logger = logger;

        /// <summary>
        /// Invoke the command handler
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public int Invoke(InvocationContext context)
        {
            Console.WriteLine("Cleaning the solution ...");
            Console.WriteLine("Building all projects...");
            Process process = new();
            process.StartInfo.FileName = "dotnet";
            process.StartInfo.Arguments = "build";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                Console.WriteLine("Build failed with exit code: " + process.ExitCode);
                return process.ExitCode;
            } 
            Console.WriteLine("Build completed with exit code: " + process.ExitCode);
            return process.ExitCode;
        }

        static void OutputHandler(object proc, DataReceivedEventArgs line) 
        {
            if (line.Data is null || line.Data.Trim() == string.Empty)
            {
                return;
            }
            Console.WriteLine(line.Data);
        }

        static int CleanSolution(string solutionPath)
        {
            Process process = new();
            process.StartInfo.FileName = "dotnet";
            process.StartInfo.Arguments = $"clean {solutionPath}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
            return process.ExitCode;
        }

        static int RestoreSolution(string solutionPath)
        {
            Process process = new();
            process.StartInfo.FileName = "dotnet";
            process.StartInfo.Arguments = $"restore {solutionPath}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
            return process.ExitCode;
        }

        /// <summary>
        /// Invoke the command handler asynchronously
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task<int> InvokeAsync(InvocationContext context)
        {
            return Task.FromResult(Invoke(context));
        }
    }
}