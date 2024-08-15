Console.Write("Anna lause: ");
string lause = Console.ReadLine();

string pisin = PisinSana(lause);
Console.WriteLine("Pisin sana : " + pisin);

static string PisinSana(string lause)
{
    string[] words = lause.Split(new char[] { ' ',',','.','!','?'}, StringSplitOptions.RemoveEmptyEntries);
    string PisinSana = string.Empty;

    foreach (string word in words)
    {
        if (word.Length > PisinSana.Length)
        {
            PisinSana = word;
        }
    }
    return PisinSana;
}