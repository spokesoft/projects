using Spectre.Console;
using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddTicketCommand : Command<AddTicketSettings>
{
    public override int Execute(CommandContext context, AddTicketSettings settings)
    {
        AnsiConsole.Markup("[underline red]Add ticket[/]");
        return 0;
    }
}