namespace Aquarium;

public class Aquarium
{
    public List<Fish> FishList = new()
    {
        new("Betta", "Blue"),
        new("Guppy", "Yellow"),
        new("Angelfish", "Silver"),
        new("Goldfish", "Orange"),
        new("Neon Tetra", "Neon blue"),
        new("Corydoras", "Bronze"),
        new("Discus", "Red"),
        new("Molly", "Black"),
        new("Zebra Danio", "Striped"),
        new("Cherry Barb", "Red"),
        new("Swordtail", "Green"),
        new("Platy", "Orange"),
        new("Rainbowfish", "Multicolored"),
        new("Clownfish", "Orange and white"),
        new("Oscar", "Black and orange"),
        new("Killifish", "Blue and red"),
        new("Pearl Gourami", "Pearlescent"),
        new("Otocinclus", "Brown"),
        new("Firemouth Cichlid", "Red and gray"),
        new("Ram Cichlid", "Blue and yellow"),
    };

    public void CreateFish(string type, string color)
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
        var filteredFish = FishList.Where(f => f.Type.Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();


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
            if (type == fish.Type && color == fish.Color)
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
        string type = "";
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

        Console.WriteLine($"A new {color} {type} fish has been born!");
        FishList.Add(new Fish(type, color));
    }

    private int Random(int min, int max)
    {
        Random random = new Random();
        var rnd = random.Next(min, max);
        return rnd;
    }
}