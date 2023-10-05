using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Picup3DigitNumber("sample.txt");
        }

        private static void Picup3DigitNumber(string file) {
            foreach (var word in File.ReadLines(file)) {
                var matches = Regex.Matches(word, @"\b\d{3,}\b");
                foreach (Match match in matches) {
                    if (match.Success)
                        Console.WriteLine(match.Value);
                }
            }
        }
    }
}
