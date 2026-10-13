/// 1 пример метода\\\

void BogdanHello()
{
    Console.WriteLine("Hello");
}

BogdanHello(); // Hello
BogdanHello(); // Hello

/// несколько примеров методов\\\

void BogdanRu()
{
    Console.WriteLine("Привет");
}
void BogdanEn()
{
    Console.WriteLine("Hello");
}
void BogdanFr()
{
    Console.WriteLine("Salut");
}


string language = "en";

switch (language)
{
    case "en":
        BogdanEn();
        break;
    case "ru":
        BogdanRu();
        break;
    case "fr":
        BogdanFr();
        break;
}

/// сокращенная зпись\\\

void BogdanHello() => Console.WriteLine("Hello");
