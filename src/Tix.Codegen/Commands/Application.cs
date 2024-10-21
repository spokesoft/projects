using System.CommandLine;

namespace Spokesoft.Tix.Codegen.Commands;

public class Application
{
    public RootCommand Root;

    public Application()
    {
        Root = [CreateScaffoldCommand()];
    }

    public Command CreateScaffoldCommand()
    {
        var command = new Command("scaffold", "Scaffold a component")
        {
            ScaffoldEntityCommand.Create(),
            ScaffoldDbContextCommand.Create(),
            ScaffoldEntityServiceCommand.Create(),
            ScaffoldEntityCreateFormCommand.Create(),
            ScaffoldEntityCreateRangeFormCommand.Create(),
            ScaffoldEntityUpdateFormCommand.Create(),
            ScaffoldEntityUpdateRangeFormCommand.Create(),
            ScaffoldEntityDeleteFormCommand.Create(),
            ScaffoldEntityDeleteRangeFormCommand.Create(),
        };
        return command;
    }

    public static class ScaffoldEntityCommand
    {
        public static Command Create()
        {
            var command = new Command("entity", "Scaffold an entity");
            return command;
        }
    }

    public static class ScaffoldDbContextCommand
    {
        public static Command Create()
        {
            var command = new Command("dbcontext", "Scaffold a db context");
            return command;
        }
    }

    public static class ScaffoldEntityServiceCommand
    {
        public static Command Create()
        {
            var command = new Command("entity:service", "Scaffold an entity CRUD service");
            return command;
        }
    }

    public static class ScaffoldEntityCreateFormCommand
    {
        public static Command Create()
        {
            var command = new Command("entity:create-form", "Scaffold an entity create form");
            return command;
        }
    }

    public static class ScaffoldEntityCreateRangeFormCommand
    {
        public static Command Create()
        {
            var command = new Command("entity:create-range-form", "Scaffold an entity create range form");
            return command;
        }
    }

    public static class ScaffoldEntityUpdateFormCommand
    {
        public static Command Create()
        {
            var command = new Command("entity:update-form", "Scaffold an entity update form");
            return command;
        }
    }

    public static class ScaffoldEntityUpdateRangeFormCommand
    {
        public static Command Create()
        {
            var command = new Command("entity:update-range-form", "Scaffold an entity update range form");
            return command;
        }
    }

    public static class ScaffoldEntityDeleteFormCommand
    {
        public static Command Create()
        {
            var command = new Command("entity:delete-form", "Scaffold an entity delete form");
            return command;
        }
    }

    public static class ScaffoldEntityDeleteRangeFormCommand
    {
        public static Command Create()
        {
            var command = new Command("entity:delete-range-form", "Scaffold an entity delete range form");
            return command;
        }
    }
}