using System;

namespace ProductSample {
    class Program {
        static void Main(string[] args) {
            //インスタンスの生成
            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(235, "大福もち", 160);
            Console.WriteLine("税込価格：" + karinto.GetPriceIncludingTax());
            Console.WriteLine("税込価格：" + daifuku.GetPriceIncludingTax());

        }
    }
}
