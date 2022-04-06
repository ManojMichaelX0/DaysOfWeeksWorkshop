using System;

namespace DaysOfWeekWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Days of Week");
            DayOfWeek dayOfWeek = new DayOfWeek();
            Console.WriteLine("Enter Month,Day,Year");
            int month=Convert.ToInt32(Console.ReadLine());
            int day =Convert.ToInt32(Console.ReadLine());
            int year=Convert.ToInt32(Console.ReadLine());
            dayOfWeek.DaysOfWeek(month, day, year);

        }
    }
}
