using DesignPatterns.Adapter.Characters.Interfaces;

namespace DesignPatterns.Adapter.Characters.Adapters;

public class BadGuyAdapter : ICharacter
{
    private readonly IBadGuy _badGuy;

    public BadGuyAdapter(IBadGuy badGuy) =>
        _badGuy = badGuy ?? throw new ArgumentNullException(nameof(badGuy));

    public int Attack() => _badGuy.Shoot();
    public int Chase() => _badGuy.Drive();
    public int Flee() => _badGuy.Drive();
}