using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddCommentSettings : AddSettings
{
    [CommandOption("-c|--comment-id <COMMENT_ID>")]
    public long? CommentId { get; set; }

    [CommandOption("-p|--project-id <PROJECT_ID>")]
    public long? ProjectId { get; set; }

    [CommandOption("-t|--ticket-id <TICKET_ID>")]
    public long? TicketId { get; set; }

    [CommandOption("-c|--content <CONTENT>")]
    public string Content { get; set; }
}