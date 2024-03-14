class Streets
{
    public static int GoTo(int money)
    {
        Console.WriteLine("You walk outside and look around");
        Console.WriteLine("You see a homeless man, a jogger and a random dude.");
        Console.WriteLine("Who do you want to rob?");
        
        string rob = Console.ReadLine();
        rob = rob.ToLower();

        if (rob == "homeless")
        {
            Console.WriteLine("You walk up to the homeless man");
            Console.WriteLine("You pull out a knife and tell him to give you all his money");
        }


    return money;
    }
}
