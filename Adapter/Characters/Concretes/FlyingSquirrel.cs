using DesignPatterns.Adapter.Characters.Interfaces;

namespace DesignPatterns.Adapter.Characters.Concretes;

public class FlyingSquirrel : IFlyingSquirrel
{
    public int Fly() => 20;
    public int DropAcorn() => 1;
}