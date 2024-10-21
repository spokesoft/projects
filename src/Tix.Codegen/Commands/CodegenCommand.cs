using System.CommandLine;

namespace Spokesoft.Tix.Codegen.Commands;

public class CodegenCommand : RootCommand
{
    public CodegenCommand(ScaffoldCommand scaffold) : base("Tix scaffolding") 
    {
        Add(scaffold);
    }
}