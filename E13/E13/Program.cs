Console.Write("Anna sana: ");
string sana = Console.ReadLine();

if (sana.Length < 2)
{
    Console.WriteLine("Sana on liian lyhyt vaihdettavaksi.");
}
else
{
    string uusiSana = SwapFirstAndLastCharacters(sana);
    Console.WriteLine("Uusi sana: " + uusiSana);
}   

    static string SwapFirstAndLastCharacters(string sana)
{
    char firstChar = sana[0];
    char lastChar = sana[sana.Length - 1];

    string middle = sana.Substring(1, sana.Length - 2);

    return lastChar + middle + firstChar;
}