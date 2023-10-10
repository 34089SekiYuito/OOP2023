using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");
            var pattern = @"\b[Vv]ersion\s*=\s*""v4.0""";
            List<string> replaced = new List<string>();
            foreach (var line in lines) {
                replaced.Add(Regex.Replace(line, pattern, "version=\"v5.0\""));
            }

            File.WriteAllLines("sample.txt", replaced);

            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}
