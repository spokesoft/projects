using Spectre.Console;
using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddCommentCommand : Command<AddCommentSettings>
{
    public override int Execute(CommandContext context, AddCommentSettings settings)
    {
        AnsiConsole.Markup("[underline red]Add comment[/]");
        return 0;
    }
}