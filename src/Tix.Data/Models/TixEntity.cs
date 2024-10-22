namespace Tix.Data.Models;

public interface ITixEntity
{
}

public class BaseTixEntity : ITixEntity
{
    public int Id { get; set; }
}

public class TixEntity : BaseTixEntity
{
}