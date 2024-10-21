using Spectre.Console;
using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddAttachmentCommand : Command<AddAttachmentSettings>
{
    public override int Execute(CommandContext context, AddAttachmentSettings settings)
    {
        AnsiConsole.Markup("[underline red]Add attachment[/]");
        return 0;
    }
}