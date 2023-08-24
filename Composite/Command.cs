namespace DesignPatterns.Composite;

public class Command
{
    public Command(string instruction) => Instruction = instruction;

    public string Instruction { get; }
}