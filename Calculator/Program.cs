Console.WriteLine("Enter the operation (+/-):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Substraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}



static void Addition(int a, int b) //sulgudes olev parameeter võib sisaldada mitu väärtust, anname a ja b väärtused. Võivad olla ükskõik mis tüüpi, aga sama tüüpi.
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Substraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}