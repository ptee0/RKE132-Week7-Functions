Console.WriteLine("Are you coming or leaving?: (in/out)");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello(); //ilma selleta ei kuva midagi, sest funktiooni pole välja kutsutud. Inglise keeles call on function/method
}
else
{
    PrintGoodBye();
}




static void PrintHello() //function ehk method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}