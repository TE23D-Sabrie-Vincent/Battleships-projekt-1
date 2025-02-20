void Spel_beskrivning()
{
    System.Console.WriteLine("Båt 1 har två rutor och båt 2 har tre rutor");
    System.Console.WriteLine("De ligger slumpmässigt över hela 4x4 spelplanen");
}



string[,] bräda = new string[4, 4];
// En 2D spelbräda som är till för skeppens positioner

void Placera_skeppet(int storlek)
{
    int rad = 1;
    int kolumn = 2;

}

void SpelBräda()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            bräda[i, j] = "~";
        }
    }
}
//Ger 2D brädet ett värde av ~ som vatten, obs: visas inte pga det ligger i konsollen

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

Spel_beskrivning();
SkrivEttNum();
SpelBräda();
Console.ReadLine();