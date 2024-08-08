internal class Program
{
    private static void Main(string[] args)
    {
        int arvo;
        int arvo2;
        int jakaus;


        //Kysytään käyttäjältä X ja Y arvo
        do
        {
            Console.WriteLine("Tervetuloa ohjelmaan. Anna arvot X ja Y niin tulostan X *= Y");
            Console.WriteLine("");
            Console.Write("Anna X:n Arvo: ");
        } while (!int.TryParse(Console.ReadLine(), out arvo));
        Console.WriteLine();
        Console.Write("Anna vielä Y:n Arvo: ");
        while (!int.TryParse(Console.ReadLine(), out arvo2)) ;
        Console.WriteLine();

        //Tulostetaan X / Y
        jakaus = arvo *= arvo2*5;
        Console.WriteLine(arvo + " *= " + arvo2 + " = " + jakaus);
    }
}