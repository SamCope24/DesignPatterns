namespace DesignPatterns.Composite;

public class FileCommandHandler : ICommandHandler<Command>
{
    public Task ExecuteCommand(Command command)
    {
        Console.WriteLine($"File: {command.Instruction}");
        return Task.CompletedTask;
    }
}