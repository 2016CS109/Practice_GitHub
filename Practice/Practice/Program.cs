using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //<//summary>
            //Console.Write("Abc");
            //Console.Write("\b");
            //Console.WriteLine("cde");
            //DateTime obj = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine(obj.Date);
            //string dateString = obj.Date.ToString();
            //Console.WriteLine(dateString);
            //string format = "MM/dd/yyyy";
            //CultureInfo provider = CultureInfo.InvariantCulture;
            //DateTime result;
            ////try
            ////{
            ////    result = DateTime.ParseExact(dateString, format, provider);
            ////    Console.WriteLine("{0} converts to {1}.", dateString, result.ToString());
            ////}
            ////catch (FormatException)
            ////{
            ////    Console.WriteLine("{0} is not in the correct format.", dateString);
            ////}
            ////dateString = "2011-29-01 12:00 am";
            ////format = "yyyy-dd-MM h:mm tt";
            ////DateTime result;
            //if (DateTime.TryParseExact(dateString, format, provider, DateTimeStyles.None, out result))
            //{
            //    Console.WriteLine("{0} converts to {1}.", dateString, result.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not in the correct format.", dateString);
            //}
            // var today = DateTime.Today;
            // DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            // var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            // var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            //Console.WriteLine((a - b) / 10000);
            //DateTime date = DateTime.Now;
            //System.DateTime BirthDate = new System.DateTime(1991, 9, 11, 0, 0, 0);
            //System.TimeSpan diffResult = date.Subtract(BirthDate);
            //string TotalDays = diffResult.Days.ToString();
            //string Months = ((diffResult.Days) % 365).ToString();
            //string RemainingMonths = (Convert.ToInt32(Months) / 31).ToString();
            //string RemainginYears = ((diffResult.Days) / 365).ToString();
            //string RemainingDays = (Convert.ToInt32(Months) % 31).ToString();
            //Console.WriteLine(RemainginYears + "-" + RemainingMonths + "-" + RemainingDays);
            //DateTime date = DateTime.Now;

            //string dateToday = date.ToString("d");
            //Console.WriteLine(dateToday);
            //DayOfWeek day = DateTime.Now.DayOfWeek;
            //Console.WriteLine(day);
            //string dayToday = day.ToString();
            //Console.WriteLine(dayToday);

            //// compare enums
            //if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday))
            //{
            //    Console.WriteLine(dateToday + " is a weekend");
            //}
            //else
            //{
            //    Console.WriteLine(dateToday + " is not a weekend");
            //}

            //// compare strings
            //if ((dayToday == DayOfWeek.Saturday.ToString()) || (dayToday == DayOfWeek.Sunday.ToString()))
            //{
            //    Console.WriteLine(dateToday + " is a weekend");
            //}
            //else
            //{
            //    Console.WriteLine(dateToday + " is not a weekend");
            //}
            //DateTime startDate = new DateTime(2018, 9, 15);
            //DateTime endDate = new DateTime(2018, 9, 23);
            //string enddateInput = endDate.ToString();
            //DateTime enddt = Convert.ToDateTime(enddateInput);
            //DayOfWeek endday = enddt.DayOfWeek;

            //string startdateInput = startDate.ToString();
            //DateTime startdt = Convert.ToDateTime(startdateInput);
            //DayOfWeek startday = startdt.DayOfWeek;
            //int EndDay = endDate.Day;
            //int StartDay = startDate.Day;
            //if (endday == DayOfWeek.Sunday)
            //{
            //    EndDay = (endDate.Day - 2);
            //}
            //if(endday == DayOfWeek.Saturday)
            //{
            //    EndDay = (endDate.Day - 1);
            //}
            //if(startday == DayOfWeek.Saturday)
            //{
            //    StartDay = (startDate.Day + 2);
            //}
            //if(startday == DayOfWeek.Sunday)
            //{
            //    StartDay = (startDate.Day + 1);
            //}
            //Console.WriteLine(EndDay);
            //Console.WriteLine(StartDay);
            //int totalDays = EndDay - StartDay + 1;
            //int totalHours = totalDays * 8;
            //Console.WriteLine(totalDays);
            //if (totalHours < 40)
            //{
            //   Console.WriteLine(totalHours);
            //}
            Console.WriteLine(DateTime.Now.AddDays(10));
        }
    }
}
