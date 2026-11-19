Console.WriteLine("Wybierz co chcesz obliczyć przez funkcje:");
Console.WriteLine("1. Silnia");
Console.WriteLine("2. Pole prostokąta");
Console.WriteLine("3. Pole kwadratu");
Console.WriteLine("4. Pole trójkąta");
Console.WriteLine("5. Pole koła");

int wybor = StrToInt("Podaj swój wybór");
int StrToInt(string text)
{
    while (true)
    {
        Console.Write($"{text}: ");
        if (int.TryParse(Console.ReadLine(), out int liczba))
        {
            return liczba;
        }

        Console.WriteLine("Podaj prawidłową liczbę całkowitą.");
    }
}
int Silnia(int a)
{
    if (a < 0)
    {
        Console.WriteLine("Silnia jest określona tylko dla liczb nieujemnych.");
        return 0;
    }

    int liczba = 1;
    for (int i = 2; i <= liczba; i++)
    {
        liczba *= i;
    }

    return liczba;
}
switch (wybor)
{
    case 1:
        int s = StrToInt("Podaj liczbę całkowitą nieujemną");
        Console.WriteLine($"Silnia: {Silnia(s)}");
        break;
    case 2:
        double a = StrToDouble("Podaj długość pierwszego boku");
        double b = StrToDouble("Podaj długość drugiego boku");
        Console.WriteLine($"Pole prostokąta: {a * b} cm²");
        break;
    case 3:
        double c = StrToDouble("Podaj długość boku kwadratu");
        Console.WriteLine($"Pole kwadratu: {c * c} cm²");
        break;
    case 4:
        double d = StrToDouble("Podaj długość podstawy");
        double h = StrToDouble("Podaj wysokość");
        Console.WriteLine($"Pole trójkąta: {d * h / 2} cm²");
        break;
    case 5:
        double r = StrToDouble("Podaj promień");
        Console.WriteLine($"Pole koła: {3.14 * r * r} cm²");
        break;
    default:
        Console.WriteLine("Nieprawidłowy wybór.");
        break;
}