namespace esercizio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("esercizio 3");

            string nome, cognome;

            Console.Write("Inserisci il tuo nome: ");
            nome = Console.ReadLine();

            Console.Write("Inserisci il tuo cognome: ");
            cognome = Console.ReadLine();

            char[] lettera1 = nome.ToCharArray();
            char[] lettera2 = cognome.ToCharArray();

            Console.WriteLine($"{lettera1[0]}.{lettera2[0]}.");
        }
    }
}
