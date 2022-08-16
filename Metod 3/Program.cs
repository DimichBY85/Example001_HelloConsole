// Вид метода 3 (что-то возращают и но нечего не принимают)

int Method3()
{
    return DateTime.Now.Year;
}

int Year = Method3();
Console.WriteLine(Year);