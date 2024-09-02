namespace Aquarium;

public class Aquarium
{
    public List<FreshwaterFish> FreshwaterFishList = new()
    {
        new(FishType.Gourami, "Blue"),
        new(FishType.Barb, "Red"),
        new(FishType.Loach, "Brown"),
        new(FishType.Tetra, "Neon Blue"),
        new(FishType.Cichlid, "Yellow"),
        new(FishType.Betta, "Blue"),
        new(FishType.Danio, "Striped"),
        new(FishType.Platy, "Orange"),
        new(FishType.Guppy, "Yellow"),
        new(FishType.Rasbora, "Silver"),
    };
    public List<SaltwaterFish> SaltwaterFishList = new()
    {
        new(FishType.Tang, "Yellow"),
        new(FishType.Wrasse, "Green"),
        new(FishType.Gobies, "Orange"),
        new(FishType.Clownfish, "Orange and White"),
        new(FishType.Angelfish, "Blue"),
        new(FishType.Blenny, "Brown"),
        new(FishType.Damselfish, "Blue"),
        new(FishType.Hawkfish, "Red"),
        new(FishType.Lionfish, "Striped"),
        new(FishType.Triggerfish, "Gray"),

    };

    public void CreateFreshFish(FishType type, string color)
    {

        FreshwaterFishList.Add(new FreshwaterFish(type, color));
    }
    public void CreateSaltFish(FishType type, string color)
    {
        SaltwaterFishList.Add(new SaltwaterFish(type, color));
    }

    public void ShowFreshFish(bool numbers)
    {
        if (numbers)
        {
            int placement = 1;
            foreach (FreshwaterFish fish in FreshwaterFishList)
            {
                Console.WriteLine("    " + placement + ". " + fish.Display());
                placement++;
            }
        }
        else
        {
            int placement = 1;
            foreach (FreshwaterFish fish in FreshwaterFishList)
            {
                Console.WriteLine("    " + fish.Display());
                placement++;
            }
        }

    }
    public void ShowSaltFish(bool numbers)
    {
        if (numbers)
        {
            int placement = 1;
            foreach (SaltwaterFish fish in SaltwaterFishList)
            {
                Console.WriteLine("    " + placement + ". " + fish.Display());
                placement++;
            }
        }
        else
        {
            int placement = 1;
            foreach (SaltwaterFish fish in SaltwaterFishList)
            {
                Console.WriteLine("    " + fish.Display());
                placement++;
            }
        }
    }

    public void FilterFish(FishType type)
    {
        IEnumerable<Fish> fishList;

        if ((int)type <= (int)FishType.Rasbora)
        {
            fishList = FreshwaterFishList;
        }
        else if ((int)type >= (int)FishType.Tang)
        {
            fishList = SaltwaterFishList;
        }
        else
        {
            Console.WriteLine("Invalid fish type");
            return;
        }

        var filteredFish = fishList.Where(f => f.Type == type).ToList();

        int placement = 1;
        foreach (var fish in filteredFish)
        {
            Console.WriteLine($"{placement}. {fish.Color} {fish.Type}");
            placement++;
        }
    }

    public void RemoveFish(FishType type, string color)
    {
        if ((int)type <= (int)FishType.Rasbora)
        {
            FreshwaterFish fishToRemove;
            foreach (FreshwaterFish fish in FreshwaterFishList)
            {
                if (type == fish.Type && color.Equals(fish.Color, StringComparison.OrdinalIgnoreCase))
                {
                    fishToRemove = fish;
                    FreshwaterFishList.Remove(fishToRemove);
                    break;
                }
            }
        }
        else if ((int)type >= (int)FishType.Tang)
        {
            SaltwaterFish fishToRemove;
            foreach (SaltwaterFish fish in SaltwaterFishList)
            {
                if (type == fish.Type && color.Equals(fish.Color, StringComparison.OrdinalIgnoreCase))
                {
                    fishToRemove = fish;
                    SaltwaterFishList.Remove(fishToRemove);
                    break;
                }
            }
        }
    }

    public void BreedFresh(int firstIndex, int secondIndex)
    {
        Fish firstFish = FreshwaterFishList[firstIndex];
        Fish secondFish = FreshwaterFishList[secondIndex];
        FishType type;
        string color;
        int random = Random(1, 2);
        if (random == 1)
        {
            type = firstFish.Type;
            color = secondFish.Color;
        }
        else if (random == 2)
        {
            type = secondFish.Type;
            color = firstFish.Color;
        }
        else
        {
            Console.WriteLine("Invalid fish");
            return;
        }


        Console.WriteLine($"A new {color} {type.ToString()} fish has been born!");
        FreshwaterFishList.Add(new FreshwaterFish(type, color));
    }
    public void BreedSalt(int firstIndex, int secondIndex)
    {
        Fish firstFish = SaltwaterFishList[firstIndex];
        Fish secondFish = SaltwaterFishList[secondIndex];
        FishType type;
        string color;
        int random = Random(1, 2);
        if (random == 1)
        {
            type = firstFish.Type;
            color = secondFish.Color;
        }
        else if (random == 2)
        {
            type = secondFish.Type;
            color = firstFish.Color;
        }
        else
        {
            Console.WriteLine("Invalid fish");
            return;
        }


        Console.WriteLine($"A new {color} {type.ToString()} fish has been born!");
        SaltwaterFishList.Add(new SaltwaterFish(type, color));
    }

    private int Random(int min, int max)
    {
        Random random = new Random();
        var rnd = random.Next(min, max + 1);
        return rnd;
    }

    public void ShowFreshFishType()
    {
        foreach (FishType fish in Enum.GetValues(typeof(FishType)))
        {
            if ((int)fish <= (int)FishType.Rasbora)
            {
                Console.WriteLine(fish);
            }
        }

    }
    public void ShowSaltFishType()
    {
        foreach (FishType fish in Enum.GetValues(typeof(FishType)))
        {
            if ((int)fish >= (int)FishType.Tang)
            {
                Console.WriteLine(fish);
            }
        }

    }
}