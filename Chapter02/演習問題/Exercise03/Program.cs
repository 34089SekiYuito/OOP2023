using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");

            //入力処理
            Console.Write("**売り上げ集計**\n1:店舗別売り上げ\n2:商品カテゴリー別売り上げ\n>");
            int num = int.Parse(Console.ReadLine());    //読み込み

            IDictionary<string, int> amount = new Dictionary<string, int>();
            if (num == 1) {
                amount = sales.GetPerStoreSales();   //店舗別売り上げの出力
            }
            else if (num == 2) {
                amount = sales.GetPerProductSales(); //商品カテゴリー別売り上げの出力
            }

            foreach (var obj in amount) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
