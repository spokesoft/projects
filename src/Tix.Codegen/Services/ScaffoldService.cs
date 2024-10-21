namespace Spokesoft.Tix.Services;

public interface IScaffoldingService
{
    public void GenerateEntity(string table, string schema);
    public void GenerateDbContext(string name, string schema);
    public void GenerateTypeConfiguration(string entity);
}

public class ScaffoldingService : IScaffoldingService
{
    public static string SolutionPath { get; set; } = Directory.GetCurrentDirectory() + "/../../";
    public static string ClientPath { get; set; } = Path.Combine(SolutionPath, "src/projects.client");
    public static string CodegenPath { get; set; } = Path.Combine(SolutionPath, "src/projects.codegen");
    public static string CommonPath { get; set; } = Path.Combine(SolutionPath, "src/projects.common");
    public static string ConsolePath { get; set; } = Path.Combine(SolutionPath, "src/projects.console");
    public static string DataPath { get; set; } = Path.Combine(SolutionPath, "src/projects.data");
    public static string DatabasePath { get; set; } = Path.Combine(SolutionPath, "src/projects.database");
    public static string RestPath { get; set; } = Path.Combine(SolutionPath, "src/projects.rest");
    public static string WebPath { get; set; } = Path.Combine(SolutionPath, "src/projects.web");

    public void Scaffold()
    {
        Console.WriteLine("Scaffolding...");
    }

    public void GenerateEntity(string table, string schema)
    {
        Console.WriteLine($"Scaffolding {table} {schema}...");
    }

    public void GenerateDbContext(string name, string schema)
    {
        Console.WriteLine($"Scaffolding dbcontext {name} from {schema}...");
    }

    public void GenerateTypeConfiguration()
    {
        Console.WriteLine("Scaffolding...");
    }
}