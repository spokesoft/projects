using Tix.Data.Models;

namespace Tix.Data.Forms;

public class CreateForm<T> : Form<T> where T : TixEntity
{
    public T Entity { get; set; }
    public long UserId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}