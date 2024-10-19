using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddReactionSettings : AddSettings
{
    [CommandOption("-cid|--comment-id <COMMENT_ID>")]
    public long? CommentId { get; set; }

    [CommandOption("-t|--type <TYPE>")]
    public string Type { get; set; }
}