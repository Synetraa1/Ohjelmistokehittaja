Console.WriteLine("Anna kaksi lukua niin palautan jakojäännöksen");
Console.Write("Ensimmäinen luku: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("Toinen luku: ");
int y = Convert.ToInt32(Console.ReadLine());

int z = x % y;
Console.WriteLine(x +  " ja " +  y + " jakojäännos on " + z);
