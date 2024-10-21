using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddProjectSettings : AddSettings
{
    [CommandOption("-n|--name <NAME>")]
    public string Name { get; set; }

    [CommandOption("-d|--description <DESCRIPTION>")]
    public string Description { get; set; }
}