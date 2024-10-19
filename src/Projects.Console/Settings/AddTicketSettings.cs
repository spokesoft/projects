using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddTicketSettings : AddSettings
{
    [CommandOption("-pid|--project-id <PROJECT_ID>")]
    public long? ProjectId { get; set; }

    [CommandOption("-t|--type <TYPE>")]
    public string Type { get; set; }
}