namespace Aquarium;

public class Aquarium
{
    public List<Fish> FishList = new()
    {
        new("Betta", "Blue", 17),
        new("Guppy", "Yellow", 23),
        new("Angelfish", "Silver", 14),
        new("Goldfish", "Orange", 28),
        new("Neon Tetra", "Neon blue", 19),
        new("Corydoras", "Bronze", 21),
        new("Discus", "Red", 15),
        new("Molly", "Black", 30),
        new("Zebra Danio", "Striped", 12),
        new("Cherry Barb", "Red", 20),
        new("Swordtail", "Green", 26),
        new("Platy", "Orange", 18),
        new("Rainbowfish", "Multicolored", 24),
        new("Clownfish", "Orange and white", 27),
        new("Oscar", "Black and orange", 16),
        new("Killifish", "Blue and red", 22),
        new("Pearl Gourami", "Pearlescent", 29),
        new("Otocinclus", "Brown", 13),
        new("Firemouth Cichlid", "Red and gray", 25),
        new("Ram Cichlid", "Blue and yellow", 30),
    };

    public void CreateFish(string type, string color, int age)
    {
        FishList.Add(new Fish(type, color, age));
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

}