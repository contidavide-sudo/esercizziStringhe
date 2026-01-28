namespace esercizio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercizio 8");

            string parola = "ciao";

            for (int i = parola.Length - 1; i >= 0; i--)
            {
                Console.Write(parola[i]);
            }
        }
    }
}
