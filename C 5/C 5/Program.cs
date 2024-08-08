Console.WriteLine("Mitä haluat syöttää?");
Console.WriteLine("1: Kokonaisluku");
Console.WriteLine("2: Double-luku");
Console.WriteLine("3: Merkkijono");
Console.WriteLine();

string valinta = Console.ReadLine();
Console.WriteLine();

switch (valinta)
{
    case "1":
        Console.Write("Syötä Kokonaisluku: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(x += 1);
        break;

    case "2":
        Console.Write("Syötä Doubleluku (Muista pilkku ei piste): ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(y += 1);
        break;

    case "3":
        Console.Write("Syötä Merkkijono: ");
        string teksti = Console.ReadLine();
        teksti += '*';
        Console.WriteLine();
        Console.WriteLine("Muokattu merkkijono: " + teksti);
        break;

    default:
        Console.WriteLine("Yritäppä Uudelleen");
        break;
}