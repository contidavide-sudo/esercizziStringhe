namespace esercizio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 2");

            string email = "conti.davide@francehttisalviani.net";

            int l = email.Length;
            int chiocciola = email.IndexOf("@");
            string dopoChiocc = email.Substring(chiocciola + 1, l - chiocciola - 1);
            Console.WriteLine($"La parte dopo la @ é: {dopoChiocc}");
        }
    }
}
