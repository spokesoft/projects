namespace Tix.Common.Models;

public class PagedResult<T> : EntityRangeResult<T>
{
    public int TotalCount { get; set; }
    public IEnumerable<T> Items { get; set; } = [];
}