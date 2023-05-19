//total < 10 -> 1%
//total >= 10 && total < 20 -> 5%
//total >= 20 -> 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput); //üks all olevatest returnidest salvestatakse siia "discount" muutujasse

Console.WriteLine($"Your discount is: {discount}%");

//double newTotal = userInput - (userInput * discount) / 100; //seda muutus, kui lisasime teise funktsiooni CalculateNewTotal
double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

//void asemel kasut andme tüüpi double, sest void puhul kustutatakse pärast funktsiooni tööd vahemälust info ära. Võib kasut ka andmetüüpi int või string jne
static double CalculateDiscount(int total)//total on parameeter, mille saan kasutajalt //
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

//NB! rida 17 olev total ja rida 34 olev total ei ole sama asi, kuna need on eraldi funktsioonides, siis neid ei panda käima samal ajal
static double CalculateNewTotal(double total, double discount)//CalculateNewTotal on funktsiooni nimi, mille mõtlen ise välja
{
    double result = total - (total * discount) / 100;
    return result;
} 