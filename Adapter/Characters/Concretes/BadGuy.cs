using DesignPatterns.Adapter.Characters.Interfaces;

namespace DesignPatterns.Adapter.Characters.Concretes;

public class BadGuy : IBadGuy
{
    public int Drive() => 30;
    public int Shoot() => 50; 
}