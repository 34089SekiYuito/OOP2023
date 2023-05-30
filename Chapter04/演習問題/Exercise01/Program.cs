using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var ym = new YearMonth(2023, 12);
            Console.WriteLine(ym.Is21Century);
            var after = ym.AddOneMonth();
            Console.WriteLine(after.ToString());
        }
    }
}
