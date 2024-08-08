Console.WriteLine("Anna kaksi lukua niin teen kaikki 4 perustoimitoimitusta");

Console.WriteLine();
Console.Write("Ensimmäinen numero: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.Write("Toinen numero: ");
double y = Convert.ToDouble(Console.ReadLine());

double tulos1 = x + y;
double tulos2 = y - x;
double tulos3 = x * y;
double tulos4 = x / y;

Console.WriteLine(x + " + " + y + " = " + tulos1);
Console.WriteLine(x + " - " + y + " = " + tulos2);
Console.WriteLine(x + " * " + y + " = " + tulos3);
Console.WriteLine(x + " / " + y + " = " + tulos4);