namespace esercizio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercizio 10");

            string parola, parolaInv = "";

            Console.Write("Inserisci una parola:");
            parola = Console.ReadLine();           

            for (int i = parola.Length - 1; i >= 0; i--)
            {
                parolaInv = parolaInv + parola[i];
            }

            if (parola == parolaInv)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
