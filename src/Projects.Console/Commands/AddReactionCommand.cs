using Spectre.Console;
using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddReactionCommand : Command<AddReactionSettings>
{
    public override int Execute(CommandContext context, AddReactionSettings settings)
    {
        AnsiConsole.Markup("[underline red]Add reaction[/]");
        return 0;
    }
}