//#define NonArray
#define StringArray
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static string[] title = { "作家　", "代表作", "誕生年", };
        static void Main(string[] args) {
            Stopwatch sw = new Stopwatch();
            sw.Start();
#if NonArray
            var text = "Novellist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            Output(text);
#elif StringArray
            string[] lines = {
                "Novellist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novellist=夏目漱石;BestWork=坊ちゃん;Born=1867",
                "Novellist=太宰治;BestWork=人間失格;Born=1909",
                "Novellist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novellist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novellist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novellist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novellist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novellist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novellist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novellist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
                "Novellist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
            };
            Output(lines);
#endif
            Console.WriteLine(sw.Elapsed.ToString(@"ss\.ffffff"));
        }

        //文字列の出力
        private static void Output(string text) {
            var words = text.Split(';');
            for (int i = 0; i < words.Length; i++) {
                Console.WriteLine("{0}:{1}", title[i], words[i].Substring(words[i].IndexOf('=') + 1));
            }
        }
        
        //配列の場合の出力
        private static void Output(string[] lines) {
            foreach (var text in lines) {
                Output(text);
            }
        }
    }
}
