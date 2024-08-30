namespace Aquarium;

public class Aquarium
{
    public List<Fish> FishList = new()
    {
        new(FishType.Betta, "Blue"),
        new(FishType.Guppy, "Yellow"),
        new(FishType.Angelfish, "Silver"),
        new(FishType.Goldfish, "Orange"),
        new(FishType.Tetra, "Neon Blue"),
        new(FishType.Corydoras, "Bronze"),
        new(FishType.Discus, "Red"),
        new(FishType.Molly, "Black"),
        new(FishType.Zebrafish, "Striped"),
        new(FishType.Cherrybarb, "Red"),
        new(FishType.Swordtail, "Green"),
        new(FishType.Platy, "Orange"),
        new(FishType.Rainbowfish, "Multicolored"),
        new(FishType.Clownfish, "Orange and White"),
        new(FishType.Oscar, "Black and Orange"),
        new(FishType.Killifish, "Blue and Red"),
        new(FishType.Gourami, "Pearlescent"),
        new(FishType.Otocinclus, "Brown"),
        new(FishType.Cichlid, "Red and Gray"),
        new(FishType.Loach, "Blue and Yellow"),

    };

    public void CreateFish(FishType type, string color)
    {
        FishList.Add(new Fish(type, color));
    }

    public void ShowFish()
    {
        int placement = 1;
        foreach (Fish fish in FishList)
        {
            Console.WriteLine(placement + ". " + fish.Color + " " + fish.Type);
            placement++;
        }
    }

    public void FilterFish(string type)
    {
        var filteredFish = FishList.Where(f => f.Type.ToString().Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();


        int placement = 1;
        foreach (Fish fish in filteredFish)
        {
            Console.WriteLine(placement + ". " + fish.Color + " " + fish.Type);
            placement++;
        }
    }

    public void RemoveFish(string type, string color)
    {
        Fish fishToRemove;
        foreach (Fish fish in FishList)
        {
            if (type == fish.Type.ToString() && color == fish.Color)
            {
                fishToRemove = fish;
                FishList.Remove(fishToRemove);
                break;
            }
        }
    }

    public void Breed(int firstIndex, int secondIndex)
    {
        Fish firstFish = FishList[firstIndex];
        Fish secondFish = FishList[secondIndex];
        FishType type = FishType.Angelfish;
        string color = "";
        if (Random(1, 2) == 1)
        {
            type = firstFish.Type;
        }
        else if (Random(1, 2) == 2)
        {
            type = secondFish.Type;
        }

        if (Random(1, 2) == 1)
        {
            color = firstFish.Color;
        }
        else if (Random(1, 2) == 2)
        {
            color = secondFish.Color;
        }

        Console.WriteLine($"A new {color} {type.ToString()} fish has been born!");
        FishList.Add(new Fish(type, color));
    }

    private int Random(int min, int max)
    {
        Random random = new Random();
        var rnd = random.Next(min, max);
        return rnd;
    }

    public void ShowFishType()
    {
        Console.WriteLine(FishType.Angelfish.ToString());
        Console.WriteLine(FishType.Betta.ToString());
        Console.WriteLine(FishType.Cherrybarb.ToString());
        Console.WriteLine(FishType.Cichlid.ToString());
        Console.WriteLine(FishType.Clownfish.ToString());
        Console.WriteLine(FishType.Corydoras.ToString());
        Console.WriteLine(FishType.Discus.ToString());
        Console.WriteLine(FishType.Goldfish.ToString());
        Console.WriteLine(FishType.Gourami.ToString());
        Console.WriteLine(FishType.Guppy.ToString());
        Console.WriteLine(FishType.Killifish.ToString());
        Console.WriteLine(FishType.Loach.ToString());
        Console.WriteLine(FishType.Molly.ToString());
        Console.WriteLine(FishType.Oscar.ToString());
        Console.WriteLine(FishType.Otocinclus.ToString());
        Console.WriteLine(FishType.Platy.ToString());
        Console.WriteLine(FishType.Rainbowfish.ToString());
        Console.WriteLine(FishType.Swordtail.ToString());
        Console.WriteLine(FishType.Tetra.ToString());
        Console.WriteLine(FishType.Zebrafish.ToString());
    }
}