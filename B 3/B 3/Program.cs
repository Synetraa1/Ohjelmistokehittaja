internal class Program
{
    private static void Main(string[] args)
    {
        int arvo;
        int kertaus;

        //Kysytään käyttäjältä Y arvo
        do
        {
            Console.Write("Hei! Anna Y:n Arvo niin kertaan tämän viidellä: ");
        } while (!int.TryParse(Console.ReadLine(), out arvo));
        Console.WriteLine();

        //Tulostetaan käyttäjälle Y * 5
        kertaus = arvo * 5;
        Console.WriteLine(arvo + " * 5 on: " + kertaus);
    }
}
