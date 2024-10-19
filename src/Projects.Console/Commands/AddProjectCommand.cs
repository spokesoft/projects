using Spectre.Console;
using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddProjectCommand : Command<AddProjectSettings>
{
    public override int Execute(CommandContext context, AddProjectSettings settings)
    {
        AnsiConsole.Markup("[underline red]Add project[/]");
        return 0;
    }
}