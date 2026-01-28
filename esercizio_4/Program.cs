namespace esercizio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercizio 4");

            string frase, frase2;

            Console.WriteLine("Inserisci una frase");

            frase = Console.ReadLine();

            frase2 = frase.Replace("brutta", "***");

            if (frase2 == frase)
            {
                Console.WriteLine("La frase non ha nulla da censurare");
            }
            else
            {
                Console.WriteLine("La frase censurata è: ");
                Console.WriteLine(frase2);
            }
        }
    }
}
