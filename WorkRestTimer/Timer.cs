namespace WorkRestTimer
{
    public class Timer
    {

        public void StartTimer()
        {

            ToContinue();

        }

        public void WorkTimer()
        {
            Console.WriteLine("Current Time:");
            DateTime startWorkDate = DateTime.Now;
            Console.WriteLine(startWorkDate);


            Console.WriteLine("\nPlease enter your Work Time(in mins):");
            double number = Convert.ToDouble(Console.ReadLine());

            int milliseconds = (int)ConvertToMilliseconds(number);

            Thread.Sleep(milliseconds);
            Console.Beep();

            Console.WriteLine("\nWork Time Ends:");
            DateTime endWorkDate = DateTime.Now;
            Console.WriteLine(endWorkDate);

            TimeSpan timeSpan = endWorkDate - startWorkDate;

            Console.WriteLine($"\nTotal time(in seconds):  {timeSpan.TotalSeconds}");

        }

        public void RestTimer()
        {
            Console.WriteLine("Current Time:");
            DateTime startRestDate = DateTime.Now;
            Console.WriteLine(startRestDate);


            Console.WriteLine("\nPlease enter your Rest Time(in mins):");
            double number = Convert.ToDouble(Console.ReadLine());

            int milliseconds = (int)ConvertToMilliseconds(number);

            Thread.Sleep(milliseconds);
            Console.Beep();

            Console.WriteLine("\nRest Time Ends:");
            DateTime endRestDate = DateTime.Now;
            Console.WriteLine(endRestDate);

            TimeSpan timeSpan = endRestDate - startRestDate;

            Console.WriteLine($"\nTotal time(in seconds):  {timeSpan.TotalSeconds}");

        }

        public double ConvertToMilliseconds(double mins)
        {
            double milliseconds = mins * 60000;

            return milliseconds;
        }

        public void ToContinue()
        {
            int sessions = 0;

            do
            {
                Console.WriteLine("Do you want to start your session? Answer true or false");
                bool answer = Convert.ToBoolean(Console.ReadLine());

                if (answer == true)
                {
                    WorkTimer();
                    RestTimer();
                    sessions++;
                    Console.WriteLine($"\nNumber of sessions: {sessions}");
                }
                else
                {
                    Console.WriteLine("Session Ends");
                    break;
                }

            }

            while (true);



        }
    }
}
