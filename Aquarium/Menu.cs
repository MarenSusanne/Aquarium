namespace Aquarium;

public class Menu
{
    private readonly Aquarium aquarium = new();

    public Menu()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Here are your fish:");
            aquarium.ShowFreshFish(false);
            aquarium.ShowSaltFish(false);
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add new fish \n2. Get rid of fish \n3. Breed fish");
            var response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 1: //Add new fish
                    Console.WriteLine();
                    Console.WriteLine("Is the new fish a Freshwater(F) or Saltwater(S) fish?");
                    var water = Console.ReadLine();
                    if (water == "F")
                    {
                        Console.WriteLine("Which of these species is the new fish?");
                        aquarium.ShowFreshFishType();
                        string typeResponse = Console.ReadLine();
                        FishType type = Enum.Parse<FishType>(typeResponse, true);
                        Console.WriteLine("What color is the new fish?");
                        string color = Console.ReadLine();
                        aquarium.CreateFreshFish(type, color);
                    }
                    else if (water == "S")
                    {
                        Console.WriteLine("Which of these species is the new fish?");
                        aquarium.ShowSaltFishType();
                        string typeResponse = Console.ReadLine();
                        FishType type = Enum.Parse<FishType>(typeResponse, true);
                        Console.WriteLine("What color is the new fish?");
                        string color = Console.ReadLine();
                        aquarium.CreateSaltFish(type, color);
                    }
                    break;

                case 2: //Get rid of fish
                    Console.WriteLine();
                    Console.WriteLine("Which fish species do you want to get rid of?");
                    string typeRemove = Console.ReadLine();
                    FishType typeToRemove = Enum.Parse<FishType>(typeRemove, true);
                    aquarium.FilterFish(typeToRemove);
                    Console.WriteLine("Which color do you want to get rid of?");
                    string colorRemove = Console.ReadLine();
                    Console.WriteLine($"Are you sure you want to remove the {colorRemove} {typeRemove}?\nY/N");
                    string lastChance = Console.ReadLine();
                    if (lastChance.ToUpper() == "Y")
                    {
                        aquarium.RemoveFish(typeToRemove, colorRemove);
                        Console.WriteLine($"Your have removed the {colorRemove} {typeRemove}");
                    }
                    else
                    {
                        Console.WriteLine("Oh thank god!");
                    }
                    break;

                case 3: //Breed fish
                    Console.WriteLine();
                    Console.WriteLine("Do you want to breed Freshwater(F) or Saltwater(S) fish?");
                    var waterType = Console.ReadLine();
                    if (waterType == "F")
                    {
                        Console.WriteLine("Which two fishes would you like to breed?");
                        aquarium.ShowFreshFish(true);
                        Console.WriteLine("First fish: (Use the numbers)");
                        int firstFish = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second fish: (Use the numbers)");
                        int secondFish = int.Parse(Console.ReadLine());
                        aquarium.BreedFresh(firstFish - 1, secondFish - 1);
                    }
                    else if (waterType == "S")
                    {
                        Console.WriteLine("Which two fishes would you like to breed?");
                        aquarium.ShowSaltFish(true);
                        Console.WriteLine("First fish: (Use the numbers)");
                        int firstFish = int.Parse(Console.ReadLine());
                        Console.WriteLine("Second fish: (Use the numbers)");
                        int secondFish = int.Parse(Console.ReadLine());
                        aquarium.BreedSalt(firstFish - 1, secondFish - 1);
                    }

                    break;
            }
        }
    }

}