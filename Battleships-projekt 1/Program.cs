using System.Threading.Tasks.Dataflow;

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
string[,] Visabräda = new string [4, 4];
// En 2D spelbräda som är till för skeppens positioner

// void Placera_skeppet(int storlek)
// {
//     int rad = 1;
//     int kolumn = 2;
// }
// Inte klart än, försöker att placera skeppet i en position där parametern bestämer storleken.

void SpelBräda()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
          bräda[i, j] = "~";
          Visabräda[i,j] = "~"; 
        }
    }
}
//Ger 2D brädet ett värde av ~ som vatten med i (X) och j (Y)

void VisaSpelBräda(){
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
           Console.Write(Visabräda[i,j] + " ");            
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

SpelBeskrivning();
DittNamn();
SkrivEttNum();
SpelBräda();
VisaSpelBräda();
Console.ReadLine();
//Påkallelse av metoderna