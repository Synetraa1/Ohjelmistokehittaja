Console.WriteLine("Anna kaksi lukua niin palautan jakojäännöksen");
Console.Write("Ensimmäinen luku: ");
Double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.Write("Toinen luku: ");
Double y = Convert.ToDouble(Console.ReadLine());

Double z = x % y;
Console.WriteLine(x + " ja " + y + " jakojäännos on " + z);
