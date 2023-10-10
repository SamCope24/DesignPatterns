using DesignPatterns.Adapter.Characters.Interfaces;

namespace DesignPatterns.Adapter.Characters.Adapters;

public class FlyingSquirrelAdapter : ICharacter
{
    private readonly IFlyingSquirrel _flyingSquirrel;

    public FlyingSquirrelAdapter(IFlyingSquirrel flyingSquirrel) =>
        _flyingSquirrel = flyingSquirrel ?? throw new ArgumentNullException(nameof(flyingSquirrel));

    public int Attack() => _flyingSquirrel.DropAcorn();
    public int Chase() => _flyingSquirrel.Fly();
    public int Flee() => _flyingSquirrel.Fly();
}