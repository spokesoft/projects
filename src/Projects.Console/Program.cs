using Projects.Console.Settings;
using Spectre.Console.Cli;

namespace Projects.Console;

public static class Program
{
    public static int Main(string[] args)
    {
        var app = new CommandApp();

        app.Configure(config =>
        {
            config.AddBranch<AddSettings>("add", add =>
            {
                add.AddCommand<AddAttachmentCommand>("attachment");
                add.AddCommand<AddCommentCommand>("comment");
                add.AddCommand<AddProjectCommand>("project");
                add.AddCommand<AddReactionCommand>("reaction");
                add.AddCommand<AddTicketCommand>("ticket");
            });
        });

        return app.Run(args);
    }
}