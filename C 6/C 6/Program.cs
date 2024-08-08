Console.Write("Ole hyvä ja kerro pisteesi: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (x < 4)
{
    int y = x * 3;
Console.WriteLine("Bonuspisteesi on " + y);
}
else if (x < 7)
{ 
    int z = x * 100;
    Console.WriteLine("Bonuspisteesi on " + z);
}
else if (x < 10)
{
    int a = x * 1000;
    Console.WriteLine("Bonuspisteesi on " + a);
}

else
{
    Console.WriteLine("Virheellinen Syöte.");
}