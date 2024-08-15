Console.Write("Anna ensimmäinen kokonaisluku: ");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Anna toinen kokonaisluku: ");
int numero2 = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine();


if (numero1 > 0 && numero2 > 0)
{
    Console.WriteLine("Molemmat ovat positiivisia");
}
else if (numero1 < 0 && numero2 < 0)
{
    Console.WriteLine("Molemmat ovat negatiivisia");
}
else
{
    Console.WriteLine("Toinen on positiivinen ja toinen on negatiivinen");
}