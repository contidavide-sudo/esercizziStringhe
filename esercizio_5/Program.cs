namespace esercizio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercizio 5");

            string voti = "8,5,7,9,6";

            string[] votiDiv = voti.Split(',');

            for(int i = 0; i < votiDiv.Length; i++)
            {
                Console.WriteLine(votiDiv[i]);
            }
        }
    }
}
