using Tix.Data.Models;

namespace Tix.Common.Models;

public class ProjectQuery : TixQuery<Ticket>
{
    public long? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
