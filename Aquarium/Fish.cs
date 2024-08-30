namespace Aquarium;

public class Fish
{
    public FishType Type { get; set; }
    public string Color { get; set; }

    public Fish(FishType type, string color)
    {
        Type = type;
        Color = color;
    }

}