namespace esercizio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercizio 7");

            string testo;
            int contatoreA = 0;

            Console.WriteLine("Inserisci il testo: ");

            testo = Console.ReadLine();

            for (int i = 0; i < testo.Length; i++) 
            { 
            
                if(testo[i] == 'a' || testo[i] == 'A')
                {
                    contatoreA = contatoreA + 1;
                }
            
            }

            Console.WriteLine($"Numero di A: {contatoreA}");
        }
    }
}
