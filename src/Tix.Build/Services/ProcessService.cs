using System.Diagnostics;

namespace Tix.Build.Services;

/// <summary>
/// Process service interface
/// </summary>

public interface IProcessService
{
    Process Create(string fileName, string arguments, string workingDirectory);
    Process Execute(string fileName, string arguments, string workingDirectory);
    Task<Process> ExecuteAsync(string fileName, string arguments, string workingDirectory);
}

/// <summary>
/// Process service implementation
/// </summary>

public class ProcessService : IProcessService
{
    /// <summary>
    /// Create a new process
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="arguments"></param>
    /// <param name="workingDirectory"></param>
    /// <returns></returns>
    
    public Process Create(string fileName, string? arguments, string? workingDirectory)
    {
        var startInfo = new ProcessStartInfo()
        {
            FileName = fileName,
            Arguments = arguments,
            CreateNoWindow = true,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            WorkingDirectory = workingDirectory
        };

        var proc = new Process()
        {
            StartInfo = startInfo
        };
        
        return proc;
    }

    public Process Create(string fileName) 
        => Create(fileName, null, null);
    public Process Create(string fileName, string arguments) 
        => Create(fileName, arguments, null);

    /// <summary>
    /// Execute a process asynchronously and return the process object
    /// </summary>
    /// <param name="file"></param>
    /// <param name="arguments"></param>
    /// <param name="workingDirectory"></param>
    /// <returns></returns>
    public async Task<Process> ExecuteAsync(string fileName, string? arguments, string? workingDirectory)
    {
        var proc = Create(fileName, arguments, workingDirectory);
        proc.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
        proc.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
        
        proc.Start();
        proc.BeginOutputReadLine();
        proc.BeginErrorReadLine();

        await proc.WaitForExitAsync();
        return proc;
    }

    public async Task<Process> ExecuteAsync(string fileName) 
        => await ExecuteAsync(fileName, null, null);
    public async Task<Process> ExecuteAsync(string fileName, string arguments) 
        => await ExecuteAsync(fileName, arguments, null);

    /// <summary>
    /// Execute a process and return the process object
    /// </summary>
    /// <param name="file"></param>
    /// <param name="arguments"></param>
    /// <param name="workingDirectory"></param>
    /// <returns></returns>
    public Process Execute(string fileName, string? arguments, string? workingDirectory)
    {
        return ExecuteAsync(fileName, arguments, workingDirectory).Result;
    }

    public Process Execute(string fileName) 
        => Execute(fileName, null, null);
    public Process Execute(string fileName, string arguments) 
        => Execute(fileName, arguments, null);

    /// <summary>
    /// Output handler for process output and error streams. Prints the output to the console.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public static void OutputHandler(object sender, DataReceivedEventArgs e)
    {
        Console.WriteLine(e.Data);
    }
}