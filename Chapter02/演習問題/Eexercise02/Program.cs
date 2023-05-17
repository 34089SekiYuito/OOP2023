using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eexercise02 {
    class Program {
        static void Main(string[] args) {
            PrintToInchMeterList(1, 10);
        }

        //インチからメートルへの対応表を出力
        private static void PrintToInchMeterList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.FromMeter(inch);
                Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
            }
        }
    }
}
