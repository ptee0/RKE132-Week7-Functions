
Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput);//sulgudesse peab panema argumendi nt stringi; userInput - argument



static void PrintAnyWord(string anyString) //anname funktsioonile parameetri () sisse; anyString - parameter
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}