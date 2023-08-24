using System.Collections.Immutable;

namespace DesignPatterns.Composite;

public class ChainCommandHandler : ICommandHandler<Command>
{
    private readonly ImmutableArray<ICommandHandler<Command>> _commandHandlers;

    public ChainCommandHandler(IEnumerable<ICommandHandler<Command>> commandHandlers)
    {
        _commandHandlers = commandHandlers?.ToImmutableArray() ?? throw new ArgumentNullException(nameof(commandHandlers));

        if (!_commandHandlers.Any())
            throw new ArgumentException("Command Handlers must be specified", nameof(commandHandlers));
    }

    public Task ExecuteCommand(Command command)
    {
        if (command is null) throw new ArgumentNullException(nameof(command));

        var executingCommands = _commandHandlers.Select(x => x.ExecuteCommand(command)).ToArray();
        return Task.WhenAll(executingCommands);
    }
}