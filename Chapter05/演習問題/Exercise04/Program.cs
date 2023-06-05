using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var text = "Novellist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            var words = text.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Count(); i++) {
                words[i] = words[i].Substring(words[i].IndexOf('=') + 1);   //'='の次の文字から格納
            }
            Console.WriteLine("作家　：{0}", words[0]);
            Console.WriteLine("代表作：{0}", words[1]);
            Console.WriteLine("誕生年：{0}", words[2]);
        }
    }
}
