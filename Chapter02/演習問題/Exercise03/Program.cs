using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");

            //店舗別売り上げの出力
            var amountPerStore = sales.GetPerStoreSales();
            foreach (var obj in amountPerStore) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
            Console.WriteLine();    //改行

            //商品別売り上げの出力
            var amountPerProduct = sales.GetPerProductSales();
            foreach (var obj in amountPerProduct) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
