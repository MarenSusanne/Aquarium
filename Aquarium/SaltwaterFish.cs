namespace Aquarium;

public class SaltwaterFish : Fish
{
    public SaltwaterFish(FishType type, string color) : base(type, color)
    {
        water = "Salt";
    }
}