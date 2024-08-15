Console.Write("Anna numero mikä on suurempi kuin 10 :) : ");
double x = Convert.ToDouble(Console.ReadLine());

if (x < 10)
{
    Console.WriteLine("Kokeile uudelleen");
}
else
{
    for (double i = 0; i < x; i++)
        Console.Write(x + " ");
}
Console.WriteLine();
for (int i = 0; i < 11; i++)
{
    Console.Write(x + " ");
}






Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Paina jotain näppäintä sulkeaksi");
Console.ReadLine();