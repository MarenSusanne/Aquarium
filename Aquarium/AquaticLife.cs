namespace Aquarium;

public class AquaticLife : IAquaticLife
{
    public string Color { get; set; }
    public void Swim()
    {
        Console.WriteLine("This fish is swimming");
    }

    public virtual string Display()
    {
        return Color;
    }
}