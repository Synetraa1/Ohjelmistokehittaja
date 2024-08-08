using System.Runtime.CompilerServices;

int arvo;
int lisäys;

//Kysytään käyttäjältä Y arvo
do {
    Console.Write("Hei! Anna Y:n Arvo niin lisään tähän +3: ");
} while(!int.TryParse(Console.ReadLine(),out arvo));
Console.WriteLine();

//Tulostetaan käyttäjälle Y + 3
lisäys= arvo + 3; 
Console.WriteLine(arvo + " + 3 on: " + lisäys);
