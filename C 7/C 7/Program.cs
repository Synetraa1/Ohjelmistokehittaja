Console.Write("Kirjoita numero 0-999 väliltä: ");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero < 0 || numero > 999)
{
    Console.WriteLine("Numero ei ole väliltä 0-999.");
}
else
{
    string sanat = MuutaNumeroSanoiksi(numero);
    Console.WriteLine($"{numero} sanoin: {sanat}");
}
    

    static string MuutaNumeroSanoiksi(int numero)
{
    if (numero == 0)
        return "Nolla";

    string sanat = "";

    if ((numero / 100) > 0)
    {
        if (numero / 100 > 1)
        {
            sanat += Ykkoset(numero / 100) + "sataa";
        }
        else
        {
            sanat += "sata";
        }
        numero %= 100;
    }

    if (numero > 0)
    {
        if (sanat != "")
            sanat += "";

        string[] ykkoset = { "", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän" };
        string[] teinit = { "kymmenen", "yksitoista", "kaksitoista", "kolmetoista", "neljätoista", "viisitoista", "kuusitoista", "seitsemäntoista", "kahdeksantoista", "yhdeksäntoista" };
        string[] kymmenet = { "", "kymmenen", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };

        if (numero < 10)
            sanat += ykkoset[numero];
        else if (numero < 20)
            sanat += teinit[numero - 10];
        else
        {
            sanat += kymmenet[numero / 10];
            if ((numero % 10) > 0)
                sanat += "" + ykkoset[numero % 10];
        }
    }

    return sanat.Trim();
}

static string Ykkoset(int numero)
{
    string[] ykkoset = { "", "Yksi", "Kaksi", "Kolme", "Neljä", "Viisi", "Kuusi", "Seitsemän", "Kahdeksan", "Yhdeksän" };
    return ykkoset[numero];
}
