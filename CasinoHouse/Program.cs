string place = "start";


int money = 100;
bool free = true;

while (place != "streets" && free)
{
    Console.WriteLine("You have " + money + " dollars");

    if (place == "start")
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("You enter the casino");
        Console.WriteLine("The bouncer asks for your ID and you hand it over åäö");
        Console.WriteLine(name + ". What a stupid name");
        Console.WriteLine("You see a blackjack table, roulette and lucky wheel");
        Console.WriteLine("Where do you want to go?");
        Console.WriteLine("Blackjack, Roulette, Lucky wheel or the streets");
        string go = Console.ReadLine();
        go = go.ToLower();

        if (go == "blackjack")
        {
            Console.WriteLine("You walk up to the blackjack table.");
            Console.WriteLine("The dealer welcomes you and you sit down.");
        }

        Console.ReadLine();

    }







    Console.ReadKey();
}










