void Spelbräda(){
System.Console.WriteLine("Båt 1 har två rutor och båt 2 har tre rutor");
System.Console.WriteLine("De ligger slumpmässigt över hela 4x4 spelplanen");
SkrivEttNum(); 




}
int SkrivEttNum(){ 
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