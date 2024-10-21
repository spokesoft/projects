using System.CommandLine;

namespace Spokesoft.Tix.Codegen.Commands;

public class ScaffoldCommand : Command
{
    public ScaffoldCommand(
        ScaffoldEntityCommand scaffoldEntityCommand,
        ScaffoldDbContextCommand scaffoldDbContextCommand
    ) : base("scaffold", "Scaffold a component") 
    {
        Add(scaffoldEntityCommand);
        Add(scaffoldDbContextCommand);

        var createForm = new Command("create-form", "Scaffold a create form");
        var updateForm = new Command("update-form", "Scaffold a update form");
        var deleteForm = new Command("delete-form", "Scaffold a delete form");
        var createRangeForm = new Command("create-range-form", "Scaffold a create range form");
        var updateRangeForm = new Command("update-range-form", "Scaffold a update range form");
        var deleteRangeForm = new Command("delete-range-form", "Scaffold a delete range form");

        Add(createForm);
        Add(updateForm);
        Add(deleteForm);
        Add(createRangeForm);
        Add(updateRangeForm);
        Add(deleteRangeForm);
    }
}