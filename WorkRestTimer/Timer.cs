namespace WorkRestTimer
{
    public class Timer
    {

       public  int Sessions { get; set; }

        public Timer()
        {
            Sessions = 0;
        }

        public void StartTimer()
        {

            ToContinue();

        }

        private void WorkTimer()
        {
            do
            {
                Console.WriteLine("Current Time:");
                try
                {
                    DateTime startWorkDate = DateTime.Now;
                    Console.WriteLine(startWorkDate);


                    Console.WriteLine("\nPlease enter your Work Time(in mins):");
                    double number = Convert.ToDouble(Console.ReadLine());

                    int milliseconds = (int)ConvertToMilliseconds(number);

                    Thread.Sleep(milliseconds);
                    Console.Beep(2000, 2000);

                    Console.WriteLine("\nWork Time Ends:");
                    DateTime endWorkDate = DateTime.Now;
                    Console.WriteLine(endWorkDate);

                    TimeSpan timeSpan = endWorkDate - startWorkDate;

                    Console.WriteLine($"\nTotal time(in seconds):  {timeSpan.TotalSeconds}");
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (true);
        }

        private void RestTimer()
        {
            do
            {
                Console.WriteLine("Current Time:");
                try
                {
                    DateTime startRestDate = DateTime.Now;
                    Console.WriteLine(startRestDate);


                    Console.WriteLine("\nPlease enter your Rest Time(in mins):");
                    double number = Convert.ToDouble(Console.ReadLine());

                    int milliseconds = (int)ConvertToMilliseconds(number);

                    Thread.Sleep(milliseconds);
                    Console.Beep(2340, 3000);

                    Console.WriteLine("\nRest Time Ends:");
                    DateTime endRestDate = DateTime.Now;
                    Console.WriteLine(endRestDate);

                    TimeSpan timeSpan = endRestDate - startRestDate;

                    Console.WriteLine($"\nTotal time(in seconds):  {timeSpan.TotalSeconds}");
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (true);
        }

        private double ConvertToMilliseconds(double mins)
        {
            double milliseconds = mins * 60000;

            return milliseconds;
        }

        private void ToContinue()
        {
            Sessions = 0;

            do
            {
                Console.WriteLine("Do you want to start your session? Answer true or false");
                try
                {
                    bool answer = Convert.ToBoolean(Console.ReadLine());

                    if (answer == true)
                    {
                        WorkTimer();
                        RestTimer();
                        Sessions++;
                        Console.WriteLine($"\nNumber of sessions: {Sessions}");
                    }
                    else
                    {
                        Console.WriteLine("Session Ends");
                        break;
                    }
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            while (true);



        }
    }
}
