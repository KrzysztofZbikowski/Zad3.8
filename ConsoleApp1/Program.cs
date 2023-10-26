class Zad
{
    static void Main(string[] args)
    {
        double oceny;
        Console.WriteLine("Podaj swoją średnią ocen: ");
        oceny = double.Parse(Console.ReadLine());
        if(oceny>=2.00 && oceny<=3.99)
        {
            Console.WriteLine("Przysługiwane stypendium wynosi 0,00 zł");
        }
        else if (oceny>=4.0 && oceny<=4.79)
        {
            Console.WriteLine("Przysługiwane stypendium wynosi 350,00 zł");
        }
        else if (oceny >= 4.80 && oceny <= 5.00)
        {
            Console.WriteLine("Przysługiwane stypendium wynosi 550,00 zł");
        }
        else
        {
            Console.WriteLine("Podano błędną średnią ocen");
        }
        Console.ReadKey();
    }
}