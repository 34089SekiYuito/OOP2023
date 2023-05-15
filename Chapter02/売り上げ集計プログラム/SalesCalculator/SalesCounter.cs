using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
