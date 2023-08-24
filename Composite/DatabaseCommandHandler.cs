namespace DesignPatterns.Composite;

public class DatabaseCommandHandler : ICommandHandler<Command>
{
    public Task ExecuteCommand(Command command)
    {
        Console.WriteLine($"Database: {command.Instruction}");
        return Task.CompletedTask;
    }
}