global using zaverecny_projekt;

Console.WriteLine("Víteh ve hřě kámen - nůžky - papír");
Console.WriteLine("Hra začíná za...");
Console.WriteLine("10");
Thread.Sleep(1000);
Console.WriteLine("9");
Thread.Sleep(1000);
Console.WriteLine("8");
Thread.Sleep(1000);
Console.WriteLine("7");
Thread.Sleep(1000);
Console.WriteLine("6");
Thread.Sleep(1000);
Console.WriteLine("5");
Thread.Sleep(1000);
Console.WriteLine("4");
Thread.Sleep(1000);
Console.WriteLine("uz skoro");
Console.WriteLine("3");
Thread.Sleep(1000);
Console.WriteLine("este pockeeeeeej");
Console.WriteLine("2");
Thread.Sleep(1000);
Console.WriteLine("1");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("NACITANI");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("chvilku pockejte (nevypínejte pocitac jinak uz nepujde zapnout)");
Thread.Sleep(6000);
Console.BackgroundColor = ConsoleColor.Blue;


Hra Hra = new Hra();
bool pokracovani = true;
int zadaniHrace = 0;
string[] volby = new string[3] { "kámen", "nůžky", "papír" };


while (pokracovani)
{
    Console.Clear();

    Console.WriteLine($"Hráč: {Hra.SkoreHrac}");
    Console.WriteLine($"Nepřítel: {Hra.SkoreNepritel}");
    Console.WriteLine("------------");
    Console.WriteLine("Kolo hráče:");
    Console.WriteLine("1 - kámen");
    Console.WriteLine("2 - nůžky");
    Console.WriteLine("3 - papír");
    Console.WriteLine("------------");

overeni:
    while (!int.TryParse(Console.ReadLine(), out zadaniHrace))
        Console.WriteLine("Neplatné číslo, zadejte znovu");
    if (zadaniHrace > 3)
    {
        Console.WriteLine("Neplatné číslo, zadejte znovu");
        goto overeni;
    }
    int volbaHrace = zadaniHrace - 1;
    Hra VolbaNepritel = new Hra();
    int volbaNepritel = VolbaNepritel.generatorVoleb.Next(3);

    if (volby[volbaHrace] == "kámen" && volby[volbaNepritel] == "nůžky")
    {
        Console.WriteLine($"Hráč vyhrál - nepřítel zvolil {volby[volbaNepritel]}");
        Hra.SkoreHrac = Hra.SkoreHrac + 1;
    }
    else if (volby[volbaHrace] == "kámen" && volby[volbaNepritel] == "papír")
    {
        Console.WriteLine($"Nepřítel vyhrál - zvolil {volby[volbaNepritel]}");
        Hra.SkoreNepritel = Hra.SkoreNepritel + 1;
    }
    else if (volby[volbaHrace] == "papír" && volby[volbaNepritel] == "kámen")
    {
        Console.WriteLine($"Hráč vyhrál - nepřítel zvolil {volby[volbaNepritel]}");
        Hra.SkoreHrac = Hra.SkoreHrac + 1;
    }
    else if (volby[volbaHrace] == "PAPER" && volby[volbaNepritel] == "nůžky")
    {
        Console.WriteLine($"Nepřítel vyhrál - zvolil {volby[volbaNepritel]}");
        Hra.SkoreNepritel = Hra.SkoreNepritel + 1; Hra.SkoreNepritel = +1;
    }
    else if (volby[volbaHrace] == "nůžky" && volby[volbaNepritel] == "kámen")
    {
        Console.WriteLine($"Nepřítel vyhrál - zvolil {volby[volbaNepritel]}");
        Hra.SkoreNepritel = Hra.SkoreNepritel + 1;
    }
    else if (volby[volbaHrace] == "nůžky" && volby[volbaNepritel] == "papír")
    {
        Console.WriteLine($"Hráč vyhrál - nepřítel zvolil {volby[volbaNepritel]}");
        Hra.SkoreHrac = Hra.SkoreHrac + 1;
    }
    else
    {
        Hra.remizy = Hra.remizy + 1;
        Console.WriteLine("Remíza");


    }
    Thread.Sleep(500);

    if (Hra.SkoreHrac > 4 | Hra.SkoreNepritel > 4)
    {
        pokracovani = false;
    }
    




}
    //idk jestli tam ma být jste nebo ste nech me byt :CCCC asi jste



    if (Hra.SkoreHrac > Hra.SkoreNepritel)
    {
        Console.WriteLine();
        Console.WriteLine("Vyhrál jsi");

    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Prohrál jsi");
        
    }
    if (Hra.remizy > 1)
    {
        Console.WriteLine($"Měli jste {Hra.remizy} remízy");
    }
    else if (Hra.remizy == 1)
    {
        Console.WriteLine($"Měli jste {Hra.remizy} remízu");
    }
    else if (Hra.remizy < 1)
    {
        Console.WriteLine("Němeli jste žádnou remízu");
    }

















