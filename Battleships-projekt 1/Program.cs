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
    System.Console.WriteLine("Tryck på valfri knapp för att gå vidare");
}

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
            bräda[rad, kolumn] = "S"; 
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
    Console.WriteLine("  1 2 3 4");
    for (int k = 0; k < 4; k++)
    {
        Console.Write(k + 1 + " "); // Radnummer
        for (int j = 0; j < 4; j++)
        {
            Console.Write(Visabräda[k, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int SkrivEttNum()
{
    string notAnum = Console.ReadLine();
    int isAnum;
    while (!int.TryParse(notAnum, out isAnum) || isAnum < 1 || isAnum > 4)
    {
        System.Console.WriteLine("Skriv ett nummer som är mellan 1-4");
        notAnum = Console.ReadLine();
    }
    return isAnum -1; //Fixar så att de blir 0
}
// Ser till så att man inte kan skriva bokstäver osv. 

bool KollaVinst()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (bräda[i, j] == "S")
            {
                return false; // Om det finns några kvar
            } 
        }
    }
    return true; // Om alla skepp är träffade
}


//Metod med spelbeskrivningen samt början av koden
DittNamn();
SpelBeskrivning();
Console.ReadKey();
SpelBräda();
PlaceraSkeppet(1, bräda);
PlaceraSkeppet(1, bräda);

while (!KollaVinst())
{
    Console.Clear();
    VisaSpelBräda();

    System.Console.WriteLine("Gissa på en kolumn från 1-4");
    int rad = SkrivEttNum();
    
    System.Console.WriteLine("Gissa på en rad från 1-4");
    int kolumn = SkrivEttNum();


    // string input = Console.ReadLine();

    // while (rad < 0 || rad >= 4 || kolumn > 0 || kolumn <= 4)
    // {
    //     System.Console.WriteLine("Gissa mellan Rad 0-4");
    //     int.TryParse(input, out rad);
    //     System.Console.WriteLine("Gissa mellan Kolumnen 0-4");
    //     int.TryParse(input, out kolumn);
    //     rad--;
    //     kolumn--;
    // }

    if (Visabräda[rad, kolumn] != "~") // Om rutan inte är betecknat som vatten så har den blivit träffad
    {
        System.Console.WriteLine("Du har ju redan träffat den här båten bruh");
        Console.ReadKey();
        continue;
    }
   if (bräda[rad, kolumn] == "S")
    {
        System.Console.WriteLine("Du träffade skeppet, najs");
        Visabräda[rad, kolumn] = "X"; // X är ett träff obviously
        bräda[rad, kolumn] = "T"; // Markerad som T i konsollen
    }

    else
    {
        System.Console.WriteLine("Du missade lol");
        Visabräda[rad,kolumn] = "O"; // Du missade haha markerad med ett O
    }
    Console.ReadKey();
}

Console.Clear();
VisaSpelBräda();
System.Console.WriteLine("Grattis du träffade alla båtar");
System.Console.WriteLine("Du klarade av spelet :D");
Console.ReadLine();
//Påkallelse av metoderna  
