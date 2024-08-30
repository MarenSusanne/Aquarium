namespace Aquarium;

public class Menu
{
    private readonly Aquarium aquarium = new();

    public Menu()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Here are your fish");
            aquarium.ShowFish();
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add new fish \n2. Get rid of fish \n3. Breed fish");
            var response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 1: //Add new fish
                    Console.WriteLine();
                    Console.WriteLine("Which of these species is the new fish?");
                    aquarium.ShowFishType();
                    string typeResponse = Console.ReadLine();
                    FishType type = Enum.Parse<FishType>(typeResponse, true);
                    Console.WriteLine("What color is the new fish?");
                    string color = Console.ReadLine();
                    aquarium.CreateFish(type, color);
                    break;

                case 2: //Get rid of fish
                    Console.WriteLine();
                    Console.WriteLine("Which fish species do you want to get rid of?");
                    string typeRemove = Console.ReadLine();
                    FishType typeToRemove = Enum.Parse<FishType>(typeRemove, true);
                    aquarium.FilterFish(typeRemove);
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
                    Console.WriteLine("Which two fishes would you like to breed?");
                    Console.WriteLine("First fish: (Use the numbers)");
                    int firstFish = int.Parse(Console.ReadLine());
                    Console.WriteLine("Second fish: (Use the numbers)");
                    int secondFish = int.Parse(Console.ReadLine());
                    aquarium.Breed(firstFish - 1, secondFish - 1);
                    break;
            }
        }
    }

}