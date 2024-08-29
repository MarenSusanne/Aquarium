namespace Aquarium;

public class Fish : IFish
{
    public string Type { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }

    public Fish(string type, string color, int age)
    {
        Type = type;
        Color = color;
        Age = age;
    }

    public void Breed()
    {

    }

    public void Swim()
    {

    }

    public void Aging()
    {

    }
}