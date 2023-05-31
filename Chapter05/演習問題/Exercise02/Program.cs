using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            //5.2
            Console.Write("数字文字列:");
            var str = Console.ReadLine();

            int num;
            int.TryParse(str, out num);
            Console.WriteLine(num.ToString("#,0"));
        }
    }
}
