namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lag en C# konsollapplikasjon som imiterer et akvarium, med masse instanser av fisker.
            //Hver "art" av fisk skal arve fra en felles klasse Fisk. Interface, Arv og Enum. INNKAPSLING
            Aquarium aquarium = new Aquarium();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Here are your fish");
                aquarium.ShowFish();
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add new fish \n2. Get rid of fish \n3. Breed fish");
                int response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 1: //Add new fish
                        Console.WriteLine();
                        Console.WriteLine("What species is the new fish?");
                        string type = Console.ReadLine();
                        Console.WriteLine("What color is the new fish?");
                        string color = Console.ReadLine();
                        Console.WriteLine("How old in months are the new fish?\n(Fish in this aquarium live between 3-5 years)");
                        int age = int.Parse(Console.ReadLine());
                        aquarium.CreateFish(type, color, age);
                        break;
                    case 2: //Get rid of fish
                        Console.WriteLine();
                        Console.WriteLine("Which fish species do you want to get rid of?");
                        string typeRemove = Console.ReadLine();
                        aquarium.FilterFish(typeRemove);
                        Console.WriteLine("Which color do you want to get rid of?");
                        string colorRemove = Console.ReadLine();
                        aquarium.RemoveFish(typeRemove, colorRemove);
                        Console.WriteLine($"Your have removed the {colorRemove} {typeRemove}");

                        break;
                    case 3: //Breed fish
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                }
            }

        }
    }
}
