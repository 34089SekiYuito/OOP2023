using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            //コンストラクタの呼び出し
            var abbrs = new Abbreviations();

            //Addメソッドの呼び出し
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //7.2.3
            //上のAddメソッドで、2つのオブジェクトを追加しているので、読み込んだ単語数+2が、Countの値になる。
            Console.WriteLine(abbrs.Count);
            Console.WriteLine();

            //7.2.3(Removeの呼び出し)
            if (abbrs.Remove("IOC"))
                Console.WriteLine(abbrs.Count);
            if (!abbrs.Remove("aaa"))
                Console.WriteLine("削除できません\n");

            //7.2.4
            //IEnumerable()を実装したので、LINQが使える。
            foreach (var item in abbrs.Where(x => x.Key.Length == 3)) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
        }
    }
}
