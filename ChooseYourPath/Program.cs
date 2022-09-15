Console.WriteLine("Welcome to ChooseYourPath");
Console.WriteLine("Type anything to login");
Console.ReadLine();
Console.Clear();

while (true)
{
    Console.WriteLine("Please enter your username (myusername) ");
    string userName = Console.ReadLine();

    Console.WriteLine("Please enter your password (mypassword): ");
    string password = Console.ReadLine();

    if (userName == "myusername" && password == "mypassword")
    {
        Console.WriteLine("You are logged in... (Type anything to continue)");
        Console.ReadLine();
        break;
    }
    else
    {
        Console.WriteLine("Wrong password or username... please try again!");
    }
}

Console.WriteLine("Time to get serious... (Press 'enter' to start the game)");
Console.ReadLine();

Console.WriteLine("done");

