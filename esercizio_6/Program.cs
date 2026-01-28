namespace esercizio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercizio 6");

            string file;

            Console.WriteLine("Inserisci il file e l'estenzione");
            file = Console.ReadLine();

            int l = file.Length;
            int ultimoPunto = file.LastIndexOf(".");
            string estenzione = file.Substring(ultimoPunto + 1, l - ultimoPunto - 1);
            Console.WriteLine($"estenzione: {estenzione}");
        }
    }
}
