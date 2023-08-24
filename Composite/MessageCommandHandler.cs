namespace DesignPatterns.Composite;

public class MessageCommandHandler : ICommandHandler<Command>
{
    public Task ExecuteCommand(Command command)
    {
        Console.WriteLine($"Message: {command.Instruction}");
        return Task.CompletedTask;
    }
}