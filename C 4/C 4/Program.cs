Console.Write("Anna Ensimmäinen kokonaisluku: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Anna Toinen kokonaisluku: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Anna Kolmas kokonaisluku: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Anna Neljäs kokonaisluku: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Anna Viides kokonaisluku: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (x > y && x > z && x > a && x > b)
{
    Console.WriteLine("Suurin luku on: " + x);
}

else if (y > x && y > z && y > a && y > b)
{
    Console.WriteLine("Suurin luku on: " + y);
}

else if (z > x && z > y && z > a && z > b)
{
    Console.WriteLine("Suurin luku on: " + z);
}

else if (a > x && a > z && a > y && a > b)
{
    Console.WriteLine("Suurin luku on: " + a);
}

else
{
    Console.WriteLine("Suurin luku on: " + b);
}