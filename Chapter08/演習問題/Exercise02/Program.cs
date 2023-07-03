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
            
            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek))) {
                nextday = NextDay(dateTime, dayOfWeek);
                Console.WriteLine("{0:yyyy/MM/dd}の次週の{1}は{2:yyyy/M/dd(ddd)}", dateTime, dayOfWeek, nextday);
            }
        }

        private static DateTime NextDay(DateTime dateTime, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)dateTime.DayOfWeek;
            days += 7;
            return dateTime.AddDays(days);
        }
    }
}
