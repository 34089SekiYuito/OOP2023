using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            //{\rtf1}
        }

        private static void Exercise3_1(string text) {
            var count = text.Count(c => c == ' ');
            Console.WriteLine(count);
        }

        private static void Exercise3_2(string text) {
            var str = text.Replace("big", "small");
            Console.WriteLine(str);
        }

        private static void Exercise3_3(string text) {
            var wordCount = text.Split(' ').Length;
            Console.WriteLine(wordCount);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4).ToList();
            words.ForEach(Console.WriteLine);
        }

        private static void Exercise3_5(string text) {
            var words = text.Split(' ');
            if (words.Length > 0) {
                var sb = new StringBuilder(words[0]);
                foreach (var word in words.Skip(1)) {
                    sb.Append(' ').Append(word);
                }
                var newText = sb.ToString();
                Console.WriteLine(newText);
            }
        }
    }
}
