Console.Write("Anna numero Fahrenheit-asteissa niin muunnan tämän Celsius-asteihin: ");
int aste = Convert.ToInt32(Console.ReadLine());

double muunnos = (aste -32) * 5 / 9;

Console.WriteLine(aste + " Fahrenheit-astetta on " + muunnos + " Celsiusta");