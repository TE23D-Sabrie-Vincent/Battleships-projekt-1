void Spelbräda()
{
    System.Console.WriteLine("Båt 1 har två rutor och båt 2 har tre rutor");
    System.Console.WriteLine("De ligger slumpmässigt över hela 4x4 spelplanen");
    SkrivEttNum();
    spelbräda();



}

string[,] bräda = new string[4, 4];

void spelbräda()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            bräda[i, j] = "~";
        }
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


Spelbräda();