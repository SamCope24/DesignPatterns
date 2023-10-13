namespace DesignPatterns.Mediator.Vanilla;

public interface IMediator
{
    void Notify(object sender, string ev);
}