

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
        Console.WriteLine("The bouncer asks for your ID and you hand it over");
        Console.WriteLine(name + ". What a stupid name");
        Console.WriteLine("Hahah okay, head inside");
        Console.WriteLine("You see a blackjack table, roulette and lucky wheel");
        Console.WriteLine("Where do you want to go?");
        Console.WriteLine("Blackjack, Roulette, Lucky wheel or the street");
        string go = Console.ReadLine();
        go = go.ToLower();

        if (go == "blackjack")
        {
            money = Blackjack.PlayBlackjack(money);
        }

        else if (go == "roulette")
        {
            money = Roulette.PlayRoulette(money);
        }

        else if (go == "Lucky wheel")
        {
            money = Wheel.PlayWheel(money);
        }

        else if (go == "Street")
        {
            money = Streets.GoTo(money);
        }



        Console.ReadLine();
    }







    Console.ReadKey();
}
