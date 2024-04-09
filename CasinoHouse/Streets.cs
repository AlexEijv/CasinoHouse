class Streets
{
    public static int GoTo(int money)
    {
        Console.WriteLine("You walk outside and look around");
        Console.WriteLine("You see a homeless man, a jogger and a random dude.");
        Console.WriteLine("Who do you want to rob?");
        
        List<string> target = new List<string> { "homeless", "jogger", "random" };

        string rob = Console.ReadLine();
        rob = rob.ToLower();

          if (target.Contains(rob))
        {
            Console.WriteLine($"You walk up to the {rob}");
            Console.WriteLine("You pull out a knife and tell him to give you all his money");
            Console.WriteLine($"You stole all {rob}'s money");
        }

         else
        {
            Console.WriteLine("Invalid choice! You decide not to rob anyone.");
        }



    return money;
    }
}
