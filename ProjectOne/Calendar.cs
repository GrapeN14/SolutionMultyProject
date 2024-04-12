using System;


namespace ProjectOne
{
    public class Calendar
    {
        public static void Main(string[] args)
        {
            DateTime now = GetCurrentDate();
            Console.WriteLine($"Today's date is {now}");
            if (args.Length != 0)
            {
                args[0] = $"Today's date is {now.ToShortDateString()}";
                return;
            }
            Console.ReadKey();
        }

        static DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }
    }
}
