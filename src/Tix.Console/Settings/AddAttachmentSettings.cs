using Spectre.Console.Cli;

namespace Projects.Console.Settings;

public class AddAttachmentSettings : AddSettings
{
    [CommandOption("-c|--comment-id <COMMENT_ID>")]
    public long? CommentId { get; set; }

    [CommandOption("-p|--project-id <PROJECT_ID>")]
    public long? ProjectId { get; set; }

    [CommandOption("-t|--ticket-id <TICKET_ID>")]
    public long? TicketId { get; set; }

    [CommandOption("-f|--file <FILE>")]
    public string File { get; set; }
}