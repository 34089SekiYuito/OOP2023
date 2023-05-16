using System;
using System.Collections.Generic;
using System.IO;

namespace SalesCalculator {
    public class SalesCounter {

        private List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(List<Sale> sales) {
            _sales = sales;
        }

        //店舗別売り上げを求める
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
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
        public static List<Sale> ReadSales(String filePath) {
            List<Sale> sales = new List<Sale>();     //売り上げデータを格納する
            string[] lines = File.ReadAllLines(filePath);   //ファイルからすべてのデータを読み込む

            //すべての行から１行ずつ取り出す
            foreach (string line in lines) {
                string[] items = line.Split(',');   //区切りで項目別に分ける
                //Saleインスタンスを生成
                Sale sale = new Sale {
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
