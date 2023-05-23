using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {

            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            ////条件の要素が存在するか
            //var exists = list.Exists(s => s[0] == 'A');
            //Console.WriteLine(exists);

            ////条件と一致する最初の要素を返却
            //var name = list.Find(s => s.Length == 6);
            //Console.WriteLine(name);

            ////条件と一致する最初の要素番号を返却
            //var index = list.FindIndex(s => s.Length == 6);
            //Console.WriteLine(index);

            //条件と一致するすべての要素を取得
            var names = list.FindAll(s => s.Length <= 5);
            names.ForEach(s => Console.WriteLine(s));

            //要素を別の型に変換
            var names2 = list.ConvertAll(s => s.ToLower());
            names2.ForEach(s => Console.WriteLine(s));


        }
    }
}
