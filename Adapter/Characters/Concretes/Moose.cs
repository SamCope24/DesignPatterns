using DesignPatterns.Adapter.Characters.Interfaces;

namespace DesignPatterns.Adapter.Characters.Concretes;

public class Moose : IMoose
{
    public int Run() => 10;
    public int Charge() => 5;
}
