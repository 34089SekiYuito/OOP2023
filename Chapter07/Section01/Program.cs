using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var Prefectures = new Dictionary<string, CityInfo>();  //県庁所在地のDictionary
            string pref, overwrite;

            //入力処理
            Console.WriteLine("県庁所在地の登録");
            Console.Write("県名:");   //県名の入力
            pref = Console.ReadLine();

            while (true) {
                if (pref == "999" || pref == "９９９") //終了
                    break;

                //入力された県がすでに存在する場合
                if (Prefectures.ContainsKey(pref)) {
                    Console.Write("すでに登録されています。上書きしますか？ y/n >");
                    overwrite = Console.ReadLine().ToLower();
                    if (overwrite == "y" || overwrite == "ｙ")   //上書きする場合
                        inputSityInfo(Prefectures, pref);
                }
                else
                    inputSityInfo(Prefectures, pref);

                //次の繰り返しの入力処理
                Console.Write("県名:");   //県名の入力
                pref = Console.ReadLine();
            }

            //出力処理
            Console.Write("1:一覧表示,2:県名指定\n>");   //出力方法の選択
            int num = int.Parse(Console.ReadLine());
            if (num == 1) {

                foreach (var Prefecture in Prefectures.OrderByDescending(p => p.Value.Population)) {
                    Console.WriteLine("{0}【{1} (人口{2}人)】", Prefecture.Key, Prefecture.Value.City, Prefecture.Value.Population);
                }
            }
            else {
                Console.Write("県名を入力:");
                var select = Console.ReadLine();
                if (Prefectures.ContainsKey(select))
                    Console.WriteLine("県庁所在地:{0}　人口:{1}人です。", Prefectures[select].City, Prefectures[select].Population);
                else
                    Console.WriteLine("登録されていません。");
            }

            #region  7-1-1
            //var flowerDict = new Dictionary<string, int>() {
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["rose"] = 500,
            //    ["dahlia"] = 450,
            //};

            ////morning glory(あさがお)【250円】を追加
            //flowerDict.Add("morning glory", 250);
            ////flowerDict["morning glory"] = 250;

            //Console.WriteLine("ひまわりの価格は{0}円です。", flowerDict["sunflower"]);
            //Console.WriteLine("チューリップの価格は{0}円です。", flowerDict["tulip"]);
            //Console.WriteLine("あさがおの価格は{0}円です。", flowerDict["morning glory"]);
            #endregion
        }

        private static void inputSityInfo(Dictionary<string, CityInfo> Prefectures, string pref) {
            Console.Write("所在地:");  //市の入力
            string city = Console.ReadLine();
            Console.Write("人口:");  //人口の入力
            int pop = int.Parse(Console.ReadLine());
            CityInfo info = new CityInfo { City = city, Population = pop };  //CityInfoインスタンスを作成
            Prefectures[pref] = info;    //登録
        }

        class CityInfo {
            public string City { get; set; }    //都市
            public int Population { get; set; }  //人口
        }
    }
}
