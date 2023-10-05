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
            foreach (var word in File.ReadAllText(file).Split(' ')) {
                if (Regex.IsMatch(word, @"^\d{3,}$"))
                    Console.WriteLine(word);
            }
        }
    }
}
