namespace esercizziStringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esecizio 1");

            string nome;

            Console.Write("Inserisci il tuo nome completo: ");

            nome = Console.ReadLine();

            nome = nome.Trim();
            nome = nome.ToUpper();
            int l = nome.Length;

            Console.WriteLine($"Il nome è {nome} ed è lungo {l}");

        }
    }
}
