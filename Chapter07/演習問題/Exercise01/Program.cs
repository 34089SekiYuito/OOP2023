using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var count = new Dictionary<char, int>();
            foreach (var Char in text.Replace(" ", "").ToUpper()) {
                if ('A' <= Char && Char <= 'Z') {
                    if (count.ContainsKey(Char))
                        count[Char]++;
                    else
                        count[Char] = 1;
                }
            }
            //出力処理
            foreach (var item in count.OrderBy(c => c.Key)) {
                Console.WriteLine("\'{0}\':{1}", item.Key, item.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var count = new SortedDictionary<char, int>();
            foreach (var Char in text.Replace(" ", "").ToUpper()) {
                if ('A' <= Char && Char <= 'Z') {
                    if (count.ContainsKey(Char))
                        count[Char]++;
                    else
                        count[Char] = 1;
                }
            }
            //出力処理
            foreach (var item in count) {
                Console.WriteLine("\'{0}\':{1}", item.Key, item.Value);
            }
        }
    }
}
