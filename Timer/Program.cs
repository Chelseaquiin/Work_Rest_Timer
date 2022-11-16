namespace Timer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DateTime startDate = DateTime.Now;

            Console.WriteLine(startDate);

            Thread.Sleep(600);

            DateTime endDate = DateTime.Now;

            Console.WriteLine(endDate);
        }
    }
}