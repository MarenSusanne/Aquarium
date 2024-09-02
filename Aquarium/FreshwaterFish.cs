namespace Aquarium;

public class FreshwaterFish : Fish
{

    public FreshwaterFish(FishType type, string color) : base(type, color)
    {
        water = "Fresh";
    }
}