internal class Program
{
    private static void Main(string[] args)
    {
        int arvo;
        int vähennys;

        //Kysytään käyttäjältä Y arvo
        do
        {
            Console.Write("Hei! Anna Y:n Arvo niin vähennän tästä 2: ");
        } while (!int.TryParse(Console.ReadLine(), out arvo));
        Console.WriteLine();

        //Tulostetaan käyttäjälle Y - 2
        vähennys = arvo - 2;
        Console.WriteLine(arvo + " - 2 on: " + vähennys);
    }
}