//Kysytään käyttäjältä kahta täysarvoa
Console.Write("Hei! Anna täyslukuarvo: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Anna toinen täyslukuarvo: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
//Tulostetaan numerot suuruus järjestyksessä
if (x < y)
{
    Console.WriteLine(x);
    Console.WriteLine(y);
}

else
{ 
        Console.WriteLine(y);
    Console.WriteLine(x);
}