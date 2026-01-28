namespace esercizio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercizio 9");

            string data = "25/12/2023", varTempo, dataFin;

            string[] arrayData = data.Split('/');

            varTempo = arrayData[0];

            arrayData[0] = arrayData[arrayData.Length - 1];

            arrayData[arrayData.Length - 1] = varTempo;

            dataFin = string.Join("-", arrayData);

            Console.WriteLine(dataFin);
        }
    }
}
