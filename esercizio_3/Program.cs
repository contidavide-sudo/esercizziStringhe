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

            char lettera1 = nome[0];
            char lettera2 = cognome[0];

            Console.WriteLine($"{lettera1}.{lettera2}.");
        }
    }
}
