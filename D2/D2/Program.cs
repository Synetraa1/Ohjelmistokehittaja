Console.Write("Anna numero Celsius-asteissa niin muunnan tämän Fahrenheit-asteihin: ");
int aste = Convert.ToInt32(Console.ReadLine());

double muunnos = aste * 1.8 + 32;

Console.WriteLine(aste + " Celsius-astetta on " +  muunnos + " Fahrenheittia");