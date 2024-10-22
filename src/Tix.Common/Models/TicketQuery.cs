using Tix.Data.Interfaces;
using Tix.Data.Models;

namespace Tix.Common.Models;

public class TicketQuery : TixQuery<Ticket>
{
    public long? Id { get; set; }
    public long? ProjectId { get; set; }
    public string? Search { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
}
