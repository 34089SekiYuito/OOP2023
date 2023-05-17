using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eexercise02 {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 3 && args[0] == "-tom") {
                PrintToInchMeterList(int.Parse(args[1]), int.Parse(args[2]));
            }
            else if (args.Length >= 3 && args[0] == "-toi") {
                PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }

        //インチからメートルへの対応表を出力
        private static void PrintToInchMeterList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.FromMeter(inch);
                Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
            }
        }

        //メートルからフィートへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double feet = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
    }
}
