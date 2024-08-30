namespace Aquarium;

public class Fish : IAquaticAnimal
{
    public FishType Type { get; set; }
    public string Color { get; set; }

    public Fish(FishType type, string color)
    {
        Type = type;
        Color = color;
    }

    public void Swim()
    {
        Console.WriteLine("This fish is swimming");
    }

    public void Display()
    {

    }
}