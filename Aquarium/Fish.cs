namespace Aquarium;

public class Fish : AquaticLife
{
    public FishType Type { get; set; }

    public Fish(FishType type, string color)
    {
        Type = type;
        Color = color;
    }

    public string water;

    public override string Display()
    {
        return Color + " " + Type;
    }
}