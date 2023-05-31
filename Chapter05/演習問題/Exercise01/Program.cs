using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            //5.1
            Console.Write("文字列1:");
            var str1 = Console.ReadLine();
            Console.Write("文字列2:");
            var str2 = Console.ReadLine();

            if(String.Compare( str1, str2,ignoreCase:true) == 0) 
                Console.WriteLine("等しい文字列です。");
            else
                Console.WriteLine("等しくない文字列です。");
        }
    }
}
