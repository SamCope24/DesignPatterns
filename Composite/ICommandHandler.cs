namespace DesignPatterns.Composite;

public interface ICommandHandler<in TCommand>
{
    public Task ExecuteCommand(TCommand command);
}