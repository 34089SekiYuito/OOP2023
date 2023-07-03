using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Now;
            DateTime nextday;
            var culture = new CultureInfo("ja-JP");

            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek))) {
                nextday = NextDay(dateTime, dayOfWeek);
                culture.DateTimeFormat.Calendar = new JapaneseCalendar();
                Console.WriteLine("{0}の次週の{1}は{2}", dateTime.ToString("yyyy/MM/dd"), dayOfWeek, nextday.ToString("yyyy/M/dd(ddd)"));
            }
        }

        private static DateTime NextDay(DateTime dateTime, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)dateTime.DayOfWeek;
            days += 7;
            return dateTime.AddDays(days);
        }
    }
}
