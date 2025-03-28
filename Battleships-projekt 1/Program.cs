// while (true)
// {
//     if (Console.KeyAvailable)
//     {
//         ConsoleKey key = Console.ReadKey().Key;
//         if (key == ConsoleKey.LeftArrow)
//         {
//             Console.WriteLine("yay");
//         }
//     }
// }
// If sats med arrow keys yay :D

void DittNamn()
{
    System.Console.WriteLine("Vad är ditt namn?");
    String Anv_namn = Console.ReadLine();
    if (Anv_namn == "")
    {
        System.Console.WriteLine("Du måste heta någonting hallå :/ ");
        Anv_namn = Console.ReadLine();
    }
    while (Anv_namn == "")
    {
        System.Console.WriteLine("Skriv ett namn nu då!!! ");
        Anv_namn = Console.ReadLine();
    }
    System.Console.WriteLine($"Hej {Anv_namn} och välkommen till budget versionen av Battleships");
}
// metod för användarens namn

void SpelBeskrivning()
{

    System.Console.WriteLine("Båt 1 har två rutor och båt 2 har tre rutor");
    System.Console.WriteLine("De ligger slumpmässigt över hela 4x4 spelplanen");
}
//Metod med spelbeskrivningen 



string[,] bräda = new string[4, 4];
string[,] Visabräda = new string[4, 4];
// En 2D spelbräda som är till för skeppens positioner                                                                                  
Random SlumpBåt = new Random();

void Placera_skeppet(int storlek)
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

SpelBeskrivning();

DittNamn();

SpelBräda();
Placera_skeppet(1);
Placera_skeppet(1);
KollaVinst();
SkrivEttNum();

Console.Clear();

VisaSpelBräda();
Console.ReadLine();
//Påkallelse av metoderna  