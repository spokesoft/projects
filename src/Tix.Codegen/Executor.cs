namespace Spokesoft.Tix.Codegen;

public interface IExecutor 
{
    void Execute();
}

public class Executor : IExecutor
{
    public void Execute()
    {
        Console.WriteLine("Inside");
    }
}