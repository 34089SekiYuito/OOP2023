using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {

            var Prefectures = new Dictionary<string, List<CityInfo>>();  //県庁所在地のDictionary
            string pref;

            //入力処理
            Console.WriteLine("都市の登録");
            Console.Write("県名:");   //県名の入力
            pref = Console.ReadLine();

            while (true) {
                if (Strings.StrConv(pref, VbStrConv.Narrow) == "999") //終了
                    break;

                if (!Prefectures.ContainsKey(pref))
                    Prefectures[pref] = new List<CityInfo>();   //入力された県が存在しない場合

                Prefectures[pref].Add(inputSityInfo());

                //次の繰り返しの入力処理
                Console.Write("県名:");   //県名の入力
                pref = Console.ReadLine();
            }

            //出力処理
            Console.Write("1:一覧表示,2:県名指定\n>");   //出力方法の選択
            int num = int.Parse(Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow));
            if (num == 1) {
                foreach (var key in Prefectures.Keys) {
                    Console.Write(key);
                    foreach (var ci in Prefectures[key].OrderByDescending(p => p.Population)) {
                        Console.Write("【{0} (人口{1}人)】", ci.City, ci.Population);
                    }
                    Console.WriteLine();
                }
            }
            else {
                Console.Write("県名を入力:");
                var select = Console.ReadLine();
                if (Prefectures.ContainsKey(select))
                    foreach (var ci in Prefectures[select].OrderByDescending(p => p.Population)) {
                        Console.WriteLine("【{0} (人口{1} 人)】", ci.City, ci.Population);
                    }
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

        private static CityInfo inputSityInfo() {
            Console.Write("都市:");  //市の入力
            string city = Console.ReadLine();
            Console.Write("人口:");  //人口の入力
            int pop = int.Parse(Strings.StrConv(Console.ReadLine(), VbStrConv.Narrow));
            return new CityInfo { City = city, Population = pop };  //CityInfoインスタンスを作成
        }

        class CityInfo {
            public string City { get; set; }    //都市
            public int Population { get; set; }  //人口
        }
    }
}
