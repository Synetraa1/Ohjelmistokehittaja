//Kysytään käyttäjältä täysarvoa
Console.Write("Ole hyvä ja anna täysarvo (0-9): ");
string numero = Console.ReadLine();
Console.WriteLine();

//Tulostetaan numero sanoina
switch(numero)
{
    case "0":
        Console.Write("Nolla");
        break;
    case "1":
        Console.Write("Yksi");
        break;
    case "2":
        Console.Write("Kaksi");
        break;
    case "3":
        Console.Write("Kolme");
        break;
    case "4":
        Console.Write("Neljä");
        break;
    case "5":
        Console.Write("Viisi");
        break;
    case "6":
        Console.Write("Kuusi");
        break;
    case "7":
        Console.Write("Seitsemän");
        break;
    case "8":
        Console.Write("Kahdeksan");
        break;
    case "9":
        Console.Write("Yhdeksän");
        break;
    default:
        Console.Write("Virheellinen syöte, anna luku 0 - 9");
        break;
}
Console.WriteLine();