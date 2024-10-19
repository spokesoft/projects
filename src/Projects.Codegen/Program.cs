// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Projects.Data.Contexts;

public class Program 
{
    public static string ConnectionString { get; set; } = "Data Source=localhost;Initial Catalog=Projects;TrustServerCertificate=true;Integrated Security=SSPI;";
    public static void Main()
    {
        Console.WriteLine("Starting ... ");
        var builder = new DbContextOptionsBuilder<ProjectsContext>();
        builder.UseSqlServer(ConnectionString);
        using (var context = new ProjectsContext(builder.Options))
        {
            var tables = context.Model.GetEntityTypes()
                .Select(table => new Table
                {
                    Schema = table.GetSchema() ?? "",
                    Name = table.GetTableName() ?? "",
                    Columns = table.GetProperties().Select(prop => new Column
                    {
                        Name = prop.Name,
                        Type = prop.ClrType.Name,
                        DeclaringType = prop.PropertyInfo.ToString(),
                        IsNullable = prop.IsNullable,
                    })
                })
                .ToList();

            foreach (var table in tables)
            {
                Console.WriteLine($"Table: {table.Name}");
                foreach (var column in table.Columns)
                {
                    Console.WriteLine(column.ToCsProperty());
                }
            }
        }
    }
}

public class Table
{
    public required string Schema { get; set; }
    public required string Name { get; set; }
    public IEnumerable<Column> Columns { get; set; } = [];
    public IEnumerable<PrimaryKey> PrimaryKeys { get; set; } = [];
    public IEnumerable<ForeignKey> ForeignKeys { get; set; } = [];
}

public class Column
{
    public static List<(string ClrType, string Alias)> TypeAliases = 
    [
        ("Boolean", "bool"),
        ("Byte", "byte"),
        ("SByte", "sbyte"),
        ("Char", "char"),
        ("Decimal", "decimal"),
        ("Double", "double"),
        ("Single", "float"),
        ("Int32", "int"),
        ("UInt32", "uint"),
        ("Int64", "long"),
        ("UInt64", "ulong"),
        ("Object", "bool"),
        ("Int16", "short"),
        ("UInt16", "ushort"),
        ("String", "string")
    ];
    public string AccessModifier { get; set; } = "public";
    public string Name { get; set; }
    public string Type { get; set; }
    public string DeclaringType { get; set; }
    public bool IsPrimaryKey { get; set; }
    public bool IsNullable { get; set; }
    public string NullableModifier => IsNullable ? "?" : "";
    public string ToCsProperty()
    {
        var match = TypeAliases.FirstOrDefault(a => a.ClrType == Type);
        var type = match.Alias ?? Type;
        return $"{AccessModifier} {type}{NullableModifier} {Name}";
    }
}
public class Index {}
public class PrimaryKey {}
public class ForeignKey {}