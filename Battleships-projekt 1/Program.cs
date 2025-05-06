void DittNamn()
{
    System.Console.WriteLine("Vad är ditt namn?");
    String anvNamn = Console.ReadLine();
    if (anvNamn == "")
    {
        System.Console.WriteLine("Du måste heta någonting hallå :/ ");
        anvNamn = Console.ReadLine();
    }
    while (anvNamn == "")
    {
        System.Console.WriteLine("Skriv ett namn nu då!!! ");
        anvNamn = Console.ReadLine();
    }
    System.Console.WriteLine($"Hej {anvNamn} och välkommen till budget versionen av Battleships");
}
// metod för användarens namn

void SpelBeskrivning()
{

    System.Console.WriteLine("Båt 1 har två rutor och båt 2 har tre rutor");
    System.Console.WriteLine("De ligger slumpmässigt över hela 4x4 spelplanen");
}
//Metod med spelbeskrivningen 
DittNamn();
SpelBeskrivning();



string[,] bräda = new string[4, 4];
string[,] Visabräda = new string[4, 4];
// En 2D spelbräda som är till för skeppens positioner                                                                                  
Random SlumpBåt = new Random();

static void PlaceraSkeppet(int storlek, string[,] bräda)
{
    while (true)
    {
        int rad = Random.Shared.Next(4);
        int kolumn = Random.Shared.Next(4);

        if (bräda[rad, kolumn] == "~")
        {
            bräda[rad, kolumn] = "X";
        }
        break;
    }
}
SkrivEttNum();

while (!KollaVinst())
{


    int rad = -1;
    int kolumn = -1;
    // För att indexen inte ska börja på 0-3 men istället 1-4

    string input = Console.ReadLine();

    while (rad < 0 || rad >= 4 || kolumn > 0 || kolumn <= 4)
    {
        System.Console.WriteLine("Gissa mellan Rad 0-4");
        int.TryParse(input, out rad);
        System.Console.WriteLine("Gissa mellan Kolumnen 0-4");
        int.TryParse(input, out kolumn);
        rad--;
        kolumn--;
    }

    if (bräda[rad, kolumn] == "X"){
        System.Console.WriteLine("Du har ju redan träffat den här båten bruh");
    }

}

void SpelBräda()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            bräda[i, j] = "~";
            Visabräda[i, j] = "~";
        }
    }
}
//Ger 2D brädet ett värde av ~ som vatten med i (X) och j (Y)
SpelBräda();


void VisaSpelBräda()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(bräda[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
Console.Clear();
VisaSpelBräda();



int SkrivEttNum()
{
    string notAnum = Console.ReadLine();
    int isAnum;
    while (!int.TryParse(notAnum, out isAnum))
    {
        System.Console.WriteLine("Skriv ett nummer");
        notAnum = Console.ReadLine();
    }
    return isAnum;
}
// Ser till så att man inte kan skriva bokstäver osv. 

bool KollaVinst()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (bräda[i, j] == "X") return false;
        }
    }
    return true;
}






PlaceraSkeppet(1, bräda);
Placera_skeppet(1);
// KollaVinst();



Console.ReadLine();
//Påkallelse av metoderna  





