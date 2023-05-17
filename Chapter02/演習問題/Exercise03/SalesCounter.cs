using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class SalesCounter {

        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(String filePath) {
            _sales = ReadSales(filePath);
        }

        //店舗別売り上げを求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new SortedDictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) {
                    //店名がすでに存在する(売り上げ加算)
                    dict[sale.ShopName] += sale.Amount;
                }
                else {
                    //店名が存在しない(新規格納)
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private IEnumerable<Sale> ReadSales(String filePath) {
            var sales = new List<Sale>();     //売り上げデータを格納する
            var lines = File.ReadAllLines(filePath);   //ファイルからすべてのデータを読み込む

            //すべての行から１行ずつ取り出す
            foreach (var line in lines) {
                var items = line.Split(',');   //区切りで項目別に分ける
                //Saleインスタンスを生成
                var sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);    //Saleインスタンスをコレクションに追加
            }
            return sales;
        }
    }
}
