Console.Write("Anna kokonaisluku välillä 1–10: ");
int luku = int.Parse(Console.ReadLine());
if (luku >= 1 && luku <= 10)
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{luku} x {i} = {luku * i}");
    }

    else
    {
        Console.WriteLine("Luku ei ole välillä 1–10.");
    }