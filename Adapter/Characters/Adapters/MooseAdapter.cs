using DesignPatterns.Adapter.Characters.Interfaces;

namespace DesignPatterns.Adapter.Characters.Adapters;

public class MooseAdapter : ICharacter
{
    private readonly IMoose _moose;

    public MooseAdapter(IMoose moose) =>
        _moose = moose ?? throw new ArgumentNullException(nameof(moose));

    public int Attack() => _moose.Charge();
    public int Chase() => _moose.Run();
    public int Flee() => _moose.Run();
}
